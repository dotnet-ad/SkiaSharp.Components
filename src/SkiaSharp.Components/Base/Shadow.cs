namespace SkiaSharp.Components
{
    public class Shadow
    {
        public Shadow(SKPoint offset, SKPoint blur, SKColor color)
        {
            this.Offset = offset;
            this.Blur = blur;
            this.Color = color;
        }

        public SKPoint Offset { get; }

        public SKPoint Blur { get; }

        public SKColor Color { get; }
    }
}
