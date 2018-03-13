namespace SkiaSharp.Components
{
    public class Icon
    {
        public Icon(SKPath path, SKStrokeCap cap, SKStrokeJoin join)
        {
            this.Path = path;
            this.Cap = cap;
            this.Join = join;
        }

        public SKPath Path { get; }

        public SKStrokeCap Cap { get; }

        public SKStrokeJoin Join { get; }
    }
}
