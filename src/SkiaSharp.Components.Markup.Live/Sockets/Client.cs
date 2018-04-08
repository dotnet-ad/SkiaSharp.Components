using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace SkiaSharp.Components.Markup.Live
{
    public class Client : Socket
    {
        public WebSocket Web { get; private set; }

        public async Task StartAsync(string uri)
        {
            Web = new ClientWebSocket();
            try
            {
                await ((ClientWebSocket)Web).ConnectAsync(new Uri(uri), CancellationToken.None);
                await this.Listen(Web);
            }
            finally
            {
                Web.Dispose();
                Web = null;
            }
        }
    }
}
