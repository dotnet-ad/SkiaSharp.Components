using System;
using System.Net.WebSockets;

namespace SkiaSharp.Components.Markup.Live
{
    public class CommandReceivedEventArgs
    {
        public CommandReceivedEventArgs(WebSocket socket, ICommand command)
        {
            this.Command = command;
            this.Socket = socket;
        }

        public ICommand Command { get; }

        public WebSocket Socket { get; }
    }
}
