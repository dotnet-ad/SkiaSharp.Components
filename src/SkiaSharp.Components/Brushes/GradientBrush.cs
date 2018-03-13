using System;
using System.Collections.Generic;
using System.Linq;

namespace SkiaSharp.Components
{
    public class GradientBrush : IBrush
    {
        public GradientBrush(SKPoint start, SKPoint end, IEnumerable<Tuple<float, SKColor>> colors)
        {
            this.Start = start;
            this.End = end;
            this.Colors = colors;
        }

        public SKPoint Start { get; set; }

        public SKPoint End { get; set; }

        public IEnumerable<Tuple<float, SKColor>> Colors { get; set; }

        private SKPaint CreatePaint(SKPath path)
        {
            var bounds = path.Bounds;
            var start = new SKPoint(bounds.Left + this.Start.X * bounds.Width, bounds.Top + this.Start.Y * bounds.Height);
            var end = new SKPoint(bounds.Left + this.End.X * bounds.Width, bounds.Top + this.End.Y * bounds.Height);

            return new SKPaint()
            {
                IsAntialias = true,
                Shader = SKShader.CreateLinearGradient(start,
                                                       end,
                                                       this.Colors.Select(x => x.Item2).ToArray(),
                                                       this.Colors.Select(x => x.Item1).ToArray(),
                                                       SKShaderTileMode.Repeat),
                Style = SKPaintStyle.Fill,
            };
        }

        public void Fill(SKCanvas canvas, SKPath path)
        {
            using (var paint = this.CreatePaint(path))
            {
                paint.Style = SKPaintStyle.Fill;
                canvas.DrawPath(path, paint);
            }
        }

        public void Stroke(SKCanvas canvas, SKPath path, float size, StrokeStyle style, SKStrokeCap cap, SKStrokeJoin join)
        {
            using (var paint = this.CreatePaint(path))
            {
                paint.StrokeWidth = size;
                paint.StrokeCap = cap;
                paint.StrokeJoin = join;
                paint.Style = SKPaintStyle.Stroke;
                canvas.DrawPath(path, paint);
            }
        }

        public void Text(SKCanvas canvas, string text, SKRect frame, SKTypeface typeface, float size, TextDecoration decorations)
        {
            var path = new SKPath();
            path.AddRect(frame);
            using (var paint = this.CreatePaint(path))
            {
                paint.IsAntialias = true;
                paint.Style = SKPaintStyle.Fill;
                paint.TextAlign = SKTextAlign.Left;
                paint.Typeface = typeface;
                paint.FakeBoldText = decorations.HasFlag(TextDecoration.Bold);
                paint.TextSize = size * Density.Global;
          
                if (decorations.HasFlag(TextDecoration.Italic))
                    paint.TextSkewX = 0.5f;

                canvas.DrawText(text, frame.Left, frame.Bottom, paint);
            }
        }
    }
}
