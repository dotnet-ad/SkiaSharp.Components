namespace SkiaSharp.Components
{
    public interface IBrush
    {
        void Text(SKCanvas canvas, string text, SKRect frame, SKTypeface typeface, float size, TextDecoration decorations);

        void Fill(SKCanvas canvas, SKPath path);

        void Stroke(SKCanvas canvas, SKPath path, float size, StrokeStyle style, SKStrokeCap cap, SKStrokeJoin join);
    }
}
