using System;

namespace SkiaSharp.Components
{
    public class LinearGradientBrush : IBrush
    {
        public LinearGradientBrush(SKColor[] colors, SKPoint direction, float[] points = null)
        {
            this.Colors = colors;
            this.Points = points;
            this.Direction = direction;
        }

        public SKPoint Direction { get; set; }

        public float[] Points { get; set; }

        public SKColor[] Colors { get; set; }

        public IDisposable Apply(SKPaint paint, SKRect frame)
        {
            // TODO direction
            var start = new SKPoint(frame.Left, frame.Top);
            var end = new SKPoint(frame.Left, frame.Bottom);
            paint.Shader = SKShader.CreateLinearGradient(start, end, this.Colors, this.Points, SKShaderTileMode.Clamp);
            return paint.Shader;
        }
    }
}
