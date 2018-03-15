using System.IO;

namespace SkiaSharp.Components.Markup.Live
{
    public class FileContentCommand : Command
    {
        public const byte Id = 1;

        public FileContentCommand() : base(Id)
        {
        }

        public string Path { get; set; }

        public bool Exists { get; set; }

        public byte[] Bytes { get; set; }

        protected override void Read(BinaryReader reader)
        {
            this.Path = reader.ReadString();
            this.Exists = reader.ReadBoolean();
            if (this.Exists)
            {
                this.Bytes = reader.ReadBytes((int)reader.BaseStream.Length - 1);
            }
        }

        protected override void Write(BinaryWriter writer)
        {
            writer.Write(this.Path);
            writer.Write(this.Exists);
            writer.Write(this.Bytes);
        }

        public override ICommand Copy() => new FileContentCommand()
        {
            Path = this.Path,
            Exists = this.Exists,
            Bytes = this.Bytes,
        };

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Path} - {this.Exists} - {this.Bytes?.Length}";
        }
    }
}