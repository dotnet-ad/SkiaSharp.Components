namespace SkiaSharp.Components
{
    public class Stroke
    {
        public Stroke(float size, IBrush brush, StrokeStyle style, SKStrokeCap cap, SKStrokeJoin join)
        {
            this.Size = size;
            this.Brush = brush;
            this.Style = style;
            this.Cap = cap;
            this.Join = join;
        }

        public float Size { get; } = 1;

        public IBrush Brush { get; }

        public StrokeStyle Style { get; }

        public SKStrokeCap Cap { get; }

        public SKStrokeJoin Join { get; }
    }
}
