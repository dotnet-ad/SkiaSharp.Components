using System;
namespace SkiaSharp.Components
{
    public interface IBrush
    {
        IDisposable Apply(SKPaint paint);
    }
}
