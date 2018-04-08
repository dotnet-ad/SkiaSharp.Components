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

        public IDisposable Apply(SKCanvas canvas, SKPaint paint, SKRect frame)
        {
            SKPoint end;

            var x = this.Direction.X > 0 ? frame.Left : frame.Right;
            var y = this.Direction.Y > 0 ? frame.Top : frame.Bottom;
            var start = new SKPoint(x, y);

            if(Math.Abs(this.Direction.X) > Math.Abs(this.Direction.Y))
            {
                var w = frame.Height * (this.Direction.X / this.Direction.Y);
                var h = frame.Height * Math.Sign(this.Direction.Y);
                end = new SKPoint(x + w, y + h);
            }
            else
            {
                var h = frame.Height * (this.Direction.Y / this.Direction.X);
                var w = frame.Width * Math.Sign(this.Direction.X);
                end = new SKPoint(x + w, y + h);
            }

            paint.Shader = SKShader.CreateLinearGradient(start, end, this.Colors, this.Points, SKShaderTileMode.Clamp);
            return paint.Shader;
        }
    }
}
