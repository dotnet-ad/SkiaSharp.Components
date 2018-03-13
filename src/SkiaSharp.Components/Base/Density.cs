namespace SkiaSharp.Components
{
    public static class Density
    {
        public static float Global { get; set; } = 1.0f;

        public static float FromPlatform(float value) => value / Global;

        public static float ToPlatform(float value) => value * Global;
    }
}
