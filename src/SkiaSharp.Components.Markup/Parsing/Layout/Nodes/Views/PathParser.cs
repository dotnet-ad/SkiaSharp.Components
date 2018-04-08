namespace SkiaSharp.Components
{
    public class PathParser : ViewNodeParser<Path>
    {
        public PathParser()
        {
            Style(this);
        }

        public static void Style<T>(ViewNodeParser<T> parser) where T : Path
        {
            parser.WithStyle<SKPath>("source", (node, view, value) => view.Source = value)
                  .WithStyle<IBrush>("fill", (node, view, value) => view.Fill = value)
                  .WithStyle<SKRect>("viewbox", (node, view, value) => view.ViewBox = value)
                  .WithStyle<Stroke>("stroke", (node, view, value) => view.Stroke = value);
        }
    }
}
