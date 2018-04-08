using System.IO;

namespace SkiaSharp.Components.Markup.Live
{
    public class FileUpdatedCommand : Command
    {
        public const byte Id = 2;

        public FileUpdatedCommand() : base(Id)
        {
        }

        public string Path { get; set; }

        protected override void Read(BinaryReader reader)
        {
            this.Path = reader.ReadString();
        }

        protected override void Write(BinaryWriter writer)
        {
            writer.Write(this.Path);
        }

        public override ICommand Copy() => new FileUpdatedCommand()
        {
            Path = this.Path,
        };

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Path}";
        }
    }
}