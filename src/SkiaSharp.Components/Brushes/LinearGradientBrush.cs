using System;

namespace SkiaSharp.Components
{
    public class LinearGradientBrush : IBrush
    {
        public LinearGradientBrush(SKPoint start, SKPoint end, float[] colors, SKPoint[] points)
        {
            this.Start = start;
            this.End = end;
        }

        private SKPoint Start { get; set; }

        private SKPoint End { get; set; }

        private float[] Points { get; set; }

        private SKColor[] Colors { get; set; }

        public IDisposable Apply(SKPaint paint)
        {
            paint.Shader = SKShader.CreateLinearGradient(this.Start, this.End, this.Colors, this.Points, SKShaderTileMode.Clamp);
            return paint.Shader;
        }
    }
}
