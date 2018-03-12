namespace SkiaSharp.Components
{
    public class Stroke
    {
        public Stroke(float size, IBrush brush, StrokeStyle style)
        {
            this.Size = size;
            this.Brush = brush;
            this.Style = style;
        }

        public float Size { get; } = 1;

        public IBrush Brush { get; }

        public StrokeStyle Style { get; }
    }
}
