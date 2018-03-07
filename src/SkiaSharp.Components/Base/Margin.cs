using System;

namespace SkiaSharp.Components
{
    public class Margin
    {
        public Margin(float all)
        {
            this.Top = this.Bottom = this.Left = this.Right = all;
        }

        public Margin(float horizontal, float vertical)
        {
            this.Left = this.Right = horizontal;
            this.Top = this.Bottom = vertical;
        }

        public Margin(float left, float top, float right, float bottom)
        {
            this.Left = left;
            this.Top = top;
            this.Right = right;
            this.Bottom = bottom;
        }

        public float Left { get; }

        public float Top { get; }

        public float Right { get; }

        public float Bottom { get; }
    }
}
