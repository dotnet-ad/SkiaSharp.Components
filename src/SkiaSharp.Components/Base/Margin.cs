using System;
using System.Linq;

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

        public static Margin Parse(string value)
        {
            var values = value.Split(',')
                              .Select(x => x.Trim())
                              .Select(x=> float.Parse(x))
                              .ToArray();

            if (values.Length < 1)
            {
                values = new[] { 0f, 0f, 0f, 0f };
            }
            if (values.Length < 2)
            {
                values = new[] { values[0], values[0], values[0], values[0] };
            }
            if (values.Length < 4)
            {
                values = new[] { values[0], values[1], values[0], values[1] };
            }

            return new Margin(values[0], values[1], values[2], values[3]);
        }
    }
}
