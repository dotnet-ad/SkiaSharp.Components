namespace SkiaSharp.Components
{
    public class BoxParser : ViewNodeParser<Box>
    {
        public BoxParser()
        {
            Style(this);    
        }

        public static void Style<T>(ViewNodeParser<T> parser) where T : Box
        {
            parser.WithStyle<float>("corner-radius", (node, view, value) => view.CornerRadius = value)
                    .WithStyle<Shadow>("shadow", (node, view, value) => view.Shadow = value)
                    .WithStyle<Stroke>("border", (node, view, value) => view.Border = value)
                    .WithStyle<IBrush>("fill", (node, view, value) => view.Fill = value);
        }
    }
}
