using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace SkiaSharp.Components.Markup.Live
{
    public class Server : Socket
    {
        public Server()
        {

        }

        #region Private

        private int count = 0;

        private List<WebSocket> webSockets = new List<WebSocket>();

        #endregion

        public Task Broadcast(ICommand command)
        {
            return Task.WhenAll(this.webSockets.Select(socket => this.Send(socket, command)));
        }

        protected virtual void OnStart() { }

        public async Task StartAsync(string listenerPrefix)
        {
            if (this.IsStarted)
                return;

            Console.WriteLine("Starting ...");

            try
            {
                var listener = new HttpListener();
                listener.Prefixes.Add(listenerPrefix);
                listener.Start();

                while (true)
                {
                    var listenerContext = await listener.GetContextAsync();

                    Console.WriteLine($"[{listenerContext.Request.Url}]");
                    Console.WriteLine($"\t-IsWebSocketRequest:{listenerContext.Request.IsWebSocketRequest}");
                    Console.WriteLine($"\t-Headers:\n{string.Join("\n\t\t-", listenerContext.Request.Headers.AllKeys.Select(x => x + ":" + listenerContext.Request.Headers[x]))}");

                    if (listenerContext.Request.IsWebSocketRequest)
                    {
                        this.OnStart();
                        ProcessRequest(listenerContext);
                    }
                    else
                    {
                        listenerContext.Response.StatusCode = 400;
                        listenerContext.Response.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private async void ProcessRequest(HttpListenerContext listenerContext)
        {
            WebSocketContext webSocketContext = null;

            try
            {
                webSocketContext = await listenerContext.AcceptWebSocketAsync(subProtocol: null);
                Interlocked.Increment(ref count);
                Console.WriteLine("Processed: {0}", count);
            }
            catch (Exception e)
            {
                listenerContext.Response.StatusCode = 500;
                listenerContext.Response.Close();
                Console.WriteLine("Exception: {0}", e);
                return;
            }

            var webSocket = webSocketContext.WebSocket;
            this.webSockets.Add(webSocket);

            try
            {
                await this.Listen(webSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e);
            }
            finally
            {
                if (webSocket != null)
                {
                    this.webSockets.Remove(webSocket);
                    webSocket.Dispose();
                }
            }
        }
    }
}