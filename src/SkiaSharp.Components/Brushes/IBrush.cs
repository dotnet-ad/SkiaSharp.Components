using System;
namespace SkiaSharp.Components
{
    public interface IBrush
    {
        IDisposable Apply(SKCanvas canvas, SKPaint paint, SKRect frame);
    }
}
