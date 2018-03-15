using System;
using System.Net.WebSockets;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Text;

namespace SkiaSharp.Components.Markup.Live
{
    public abstract class Command : ICommand
    {
        public Command(byte identifier)
        {
            this.Identifier = identifier;
        }

        public byte Identifier { get; }

        public async Task Read(WebSocketReceiveResult result, byte[] firstBytes, WebSocket webSocket)
        {
            Console.WriteLine($"Received command {this}...");

            try
            {
                using (var memory = new MemoryStream())
                using (var writer = new BinaryWriter(memory, Encoding.UTF8))
                {
                    writer.Write(firstBytes.Take(result.Count).Skip(1).ToArray());

                    while (webSocket.State == WebSocketState.Open && !result.EndOfMessage)
                    {
                        result = await webSocket.ReceiveAsync(new ArraySegment<byte>(firstBytes), CancellationToken.None);
                        writer.Write(firstBytes, 0, result.Count);
                    }

                    memory.Seek(0, SeekOrigin.Begin);
                    memory.Position = 0;

                    using (var reader = new BinaryReader(memory, Encoding.UTF8))
                    {
                        this.Read(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public async Task Write(WebSocket webSocket)
        {
            Console.WriteLine($"Sending command {this}...");

            using (var memory = new MemoryStream())
            using (var writer = new BinaryWriter(memory))
            {
                writer.Write(this.Identifier);
                Write(writer);

                memory.Seek(0, SeekOrigin.Begin);
                memory.Position = 0;

                using (var reader = new BinaryReader(memory))
                {
                    var buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        var isEnd = memory.Position >= memory.Length - 1;
                        await webSocket.SendAsync(new ArraySegment<byte>(buffer, 0, bytesRead), WebSocketMessageType.Binary, isEnd, CancellationToken.None);
                    }
                }
            }
        }

        protected abstract void Read(BinaryReader reader);

        protected abstract void Write(BinaryWriter writer);

        public abstract ICommand Copy();
    }
}