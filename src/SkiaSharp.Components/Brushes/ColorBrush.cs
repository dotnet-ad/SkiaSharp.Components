using System;

namespace SkiaSharp.Components
{
    public class ColorBrush : IBrush
    {
        public ColorBrush(SKColor color)
        {
            this.Color = color;
        }

        public SKColor Color { get; }

        public void Fill(SKCanvas canvas, SKPath path)
        {
            using (var paint = new SKPaint()
            {
                IsAntialias = true,
                Color = Color,
                Style = SKPaintStyle.Fill,
            })
            {
                canvas.DrawPath(path, paint);
            }
        }

        public void Stroke(SKCanvas canvas, SKPath path, float size, StrokeStyle style)
        {
            using (var paint = new SKPaint()
            {
                IsAntialias = true,
                StrokeWidth = size,
                Color = this.Color,
                Style = SKPaintStyle.Stroke,
                StrokeCap = SKStrokeCap.Round,
            })
            {
                if (style == StrokeStyle.Dotted)
                {
                    paint.PathEffect = SKPathEffect.CreateDash(new[] { 0, size * 2, 0, size * 2 }, 0);
                }
                else if (style == StrokeStyle.Dashed)
                {
                    paint.PathEffect = SKPathEffect.CreateDash(new[] { size * 6, size * 2 }, 0);
                }

                canvas.DrawPath(path, paint);
            }
        }

        public void Text(SKCanvas canvas, string text, SKRect frame, SKTypeface typeface, float size, TextDecoration decorations)
        {
            using (var paint = new SKPaint()
            {
                IsAntialias = true,
                Color = Color,
                Style = SKPaintStyle.Fill,
                TextAlign = SKTextAlign.Left,
                Typeface = typeface,
                FakeBoldText = decorations.HasFlag(TextDecoration.Bold),
                TextSize = size * Density.Global,
            })
            {
                if (decorations.HasFlag(TextDecoration.Italic))
                    paint.TextSkewX = 0.5f;

                canvas.DrawText(text, frame.Left, frame.Bottom, paint);
            }
        }
    }
}
