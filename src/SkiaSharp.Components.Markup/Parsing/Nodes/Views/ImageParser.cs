namespace SkiaSharp.Components
{
    public class ImageParser : ViewNodeParser<Image>
    {
        public ImageParser()
        {
            Style(this);
        }

        public static void Style<T>(ViewNodeParser<T> parser) where T : Image
        {
            BoxParser.Style(parser);
        }
    }
}
