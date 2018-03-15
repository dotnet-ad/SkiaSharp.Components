using System.Net.WebSockets;
using System.Threading.Tasks;

namespace SkiaSharp.Components.Markup.Live
{
    public interface ICommand
    {
        byte Identifier { get; }

        Task Read(WebSocketReceiveResult result, byte[] firstBytes, WebSocket webSocket);

        Task Write(WebSocket webSocket);

        ICommand Copy();
    }
}