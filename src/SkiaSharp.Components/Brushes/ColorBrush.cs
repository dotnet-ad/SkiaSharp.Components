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

        public IDisposable Apply(SKCanvas canvas, SKPaint paint, SKRect frame)
        {
            paint.Color = this.Color;
            return null;
        }

     
    }
}
