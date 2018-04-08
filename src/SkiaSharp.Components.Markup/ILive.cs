namespace SkiaSharp.Components.Markup
{
    public interface ILive
    {
        void Connect(Flex view);
    }

    public static class Development
    {
        public static ILive Current { get; set; }
    }
}
