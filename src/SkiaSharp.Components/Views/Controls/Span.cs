namespace SkiaSharp.Components
{
    public class Span
    {
        public Span()
        {
            this.ForegroundBrush = new ColorBrush(SKColors.Black);
            this.TextSize = 12;
            this.Decorations = TextDecoration.None;
        }

        public Span(Span source)
        {
            this.Text = source.Text;
            this.ForegroundBrush = source.ForegroundBrush;
            this.TextSize = source.TextSize;
            this.Typeface = source.Typeface;
            this.Decorations = source.Decorations;
        }

        public string Text { get; set; }

        public IBrush ForegroundBrush { get; set; }

        public float TextSize { get; set; }

        public int Line { get; set; }

        public SKRect Bounds { get; set; }

        public SKRect LayoutFrame { get; set; }

        public SKTypeface Typeface { get; set; }

        public TextDecoration Decorations { get; set; }
    }
}
