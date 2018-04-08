namespace SkiaSharp.Components
{
    public class LabelParser : ViewNodeParser<Label>
    {
        public LabelParser()
        {
            Style(this);
        }

        public static void Style<T>(ViewNodeParser<T> parser) where T : Label
        {
            parser.WithStyle<float>("text-size", (node, view, value) => view.TextSize = value)
                  .WithStyle<IBrush>("foreground", (node, view, value) => view.ForegroundBrush = value)
                  .WithStyle<float>("line-height", (node, view, value) => view.LineHeight = value);
        }
    }
}
