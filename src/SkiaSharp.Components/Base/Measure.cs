using System;

namespace SkiaSharp.Components
{
    public enum MeasurementMode
    {
        Auto,
        Fixed,
    }

    public class Measure
    {
        private Measure(MeasurementMode mode, float size)
        {
            this.Mode = mode;
            this.Size = size;
        }

        public MeasurementMode Mode { get; }

        public float Size { get; }

        public static Measure Auto() => new Measure(MeasurementMode.Auto, 0);

        public static Measure Fixed(float size) => new Measure(MeasurementMode.Fixed, size);
    }
}
