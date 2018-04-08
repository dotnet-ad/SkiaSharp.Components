using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SkiaSharp.Components.Markup.Live
{
    public class Socket
    {
        public Socket()
        {
            this.CommandReceived += (sender, e) => this.OnCommandReceived(e.Socket, e.Command);
        }

        #region Private

        private Dictionary<byte, ICommand> commands = new Dictionary<byte, ICommand>();

        #endregion

        #region Properties

        public bool IsStarted { get; private set; }

        #endregion

        #region Events

        public event EventHandler<CommandReceivedEventArgs> CommandReceived;

        #endregion

        public void RegisterCommand(ICommand command)
        {
            this.commands.Add(command.Identifier, command);
        }

        public Task Send(WebSocket socket, ICommand command)
        {
            Console.WriteLine("Sending command with id:" + command.Identifier);
            return command.Write(socket);
        }

        protected virtual void OnCommandReceived(WebSocket socket, ICommand command) { }

        protected async Task Listen(WebSocket socket)
        {
            this.IsStarted = true;

            try
            {
                var bytesReceived = new byte[4096];

                while (socket.State == WebSocketState.Open)
                {
                    var receiveResult = await socket.ReceiveAsync(new ArraySegment<byte>(bytesReceived), CancellationToken.None);
                    if (receiveResult.MessageType == WebSocketMessageType.Close)
                    {
                        await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
                    }
                    else
                    {
                        var identifier = bytesReceived.FirstOrDefault();
                        Console.WriteLine("Received command with id:" + identifier);
                        if (this.commands.TryGetValue(identifier, out ICommand prototype))
                        {
                            var command = prototype.Copy();
                            await command.Read(receiveResult, bytesReceived, socket);
                            this.CommandReceived?.Invoke(this, new CommandReceivedEventArgs(socket, command));
                        }
                        else
                        {
                            while (socket.State == WebSocketState.Open && !receiveResult.EndOfMessage)
                            {
                                receiveResult = await socket.ReceiveAsync(new ArraySegment<byte>(bytesReceived), CancellationToken.None);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex);
                throw;
            }
            finally
            {
                this.IsStarted = false;
            }

        }
    }
}