using System;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;

namespace SkiaSharp.Components.Markup.Live
{
    public class LiveServer : Server
    {
        #region Constructors

        public LiveServer(string localPath, string fileFilter)
        {
            this.localPath = localPath;
            this.fileFilter = fileFilter;

            this.RegisterCommand(new FileContentRequestedCommand());
        }

        #endregion

        #region Fields

        private string localPath, fileFilter;

        private List<WebSocket> webSockets = new List<WebSocket>();

        #endregion

        #region Methods

        protected override void OnStart()
        {
            base.OnStart();

            var watcher = new FileSystemWatcher()
            {
                Path = localPath,
                NotifyFilter = NotifyFilters.LastWrite,
                IncludeSubdirectories = true,
                Filter = fileFilter,
            };
            watcher.Changed += OnFileChanged;
            watcher.EnableRaisingEvents = true;
        }

        private string ToAbsolute(string path)
        {
            return System.IO.Path.Combine(this.localPath, path.TrimStart('/', '\\'));
        }

        private string ToRelative(string path)
        {
            return path.Replace(this.localPath, "");
        }
        protected override async void OnCommandReceived(WebSocket socket, ICommand command)
        {
            base.OnCommandReceived(socket, command);

            try
            {
                switch (command)
                {
                    case FileContentRequestedCommand requested:
                        var absolute = ToAbsolute(requested.Path);
                        Console.WriteLine($"Requested file : '{requested.Path}' ({absolute})");
                        var exists = File.Exists(absolute);
                        await this.Send(socket, new FileContentCommand
                        {
                            Path = requested.Path,
                            Exists = exists,
                            Bytes = exists ? File.ReadAllBytes(absolute) : new byte[0],
                        });
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Command received error : " + ex);
            }
        }

        private async void OnFileChanged(object source, FileSystemEventArgs e)
        {
            try
            {
                var relative = ToRelative(e.FullPath);
                Console.WriteLine($"File updated : '{relative}' ({e.FullPath})");
                await this.Broadcast(new FileUpdatedCommand
                {
                    Path = relative,
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        #endregion
    }
}