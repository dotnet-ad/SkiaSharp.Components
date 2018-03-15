using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Xml.Linq;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Diagnostics;
using System.Xml;
using System.Threading;
using System.Security.Cryptography;

namespace SkiaSharp.Components.Markup.Live
{
    public class LiveClient : Client, ILive
    {
        private List<WeakReference<Flex>> layouts = new List<WeakReference<Flex>>();

        public LiveClient()
        {
            this.RegisterCommand(new FileUpdatedCommand());
            this.RegisterCommand(new FileContentCommand());
        }

        public async void Connect(Flex view)
        {
            this.layouts.Add(new WeakReference<Flex>(view));
        }

        protected override void OnCommandReceived(WebSocket socket, ICommand command)
        {
            base.OnCommandReceived(socket, command);

            switch (command)
            {
                case FileUpdatedCommand updated:
                    this.OnFileUpdated(updated.Path);
                    break;
            }
        }

        protected async void OnFileUpdated(string id)
        {
            id = id.TrimStart('/', '\\');

            if (System.IO.Path.HasExtension(".skml"))
            {
                Debug.WriteLine($"[Live] File updated '{id}'...");

                try
                {
                    // Finding layouts with given id and removing released references
                    List<Flex> flexes = new List<Flex>();
                    for (int i = 0; i < layouts.Count;)
                    {
                        var layout = layouts[i];
                        if (layout.TryGetTarget(out Flex instance))
                        {
                            if (instance.Name == id)
                            {
                                flexes.Add(instance);
                            }
                            i++;
                        }
                        else
                        {
                            layouts.Remove(layout);
                        }
                    }

                    // Updating connected layouts with given id
                    if (flexes.Count > 0)
                    {
                        foreach (var flex in flexes)
                        {
                            await ReloadLayout(flex);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[Live] Error: '{ex}'");
                }
            }
        }

        private async Task ReloadLayout(Flex flex)
        {
            if(flex.Name != null)
            {
                Debug.WriteLine($"[Live] Reloading layout '{flex.Name}'...");

                try
                {
                    var skmlParser = new SkmlParser(GetContentAsync);
            
                    var newFlex = await skmlParser.ParseAsync(new Layout
                    {
                        Path = flex.Name,
                    });
                    flex.Root = newFlex.View.Root;

                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"[Live] Error: '{ex}'");
                }
            }
        }

        private SemaphoreSlim getContentSemaphore = new SemaphoreSlim(1);

        public async Task<Stream> GetContentAsync(string path)
        {
            getContentSemaphore.Wait();

            var tcs = new TaskCompletionSource<byte[]>();

            EventHandler<CommandReceivedEventArgs> action = null;

            // TODO timeout
            action = (sender, e) =>
            {
                try
                {
                    switch (e.Command)
                    {
                        case FileContentCommand content:
                            if (content.Exists)
                            {
                                tcs.SetResult(content.Bytes);
                            }
                            else
                            {
                                throw new Exception($"File '{content.Path}' doesn't exist.");
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    tcs.SetException(ex);
                }
                finally
                {
                    this.CommandReceived -= action;
                }
            };

            this.CommandReceived += action;

            await this.Send(this.Web, new FileContentRequestedCommand()
            {
                Path = path,
            });

            try
            {
                var bytes = await tcs.Task;

                // Bytes to stream
                var memory = new MemoryStream();
                using (var writer = new BinaryWriter(memory, Encoding.UTF8, true))
                {
                    writer.Write(bytes);
                }
                memory.Seek(0, SeekOrigin.Begin);
                return memory;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw ex;
            }
            finally
            {
                getContentSemaphore.Release();
            }
        }
    }
}
