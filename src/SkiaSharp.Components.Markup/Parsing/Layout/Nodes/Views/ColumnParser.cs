namespace SkiaSharp.Components
{
    public class ColumnParser : NodeParser
    {
        public ColumnParser() : base("Column")
        {
            this.WithMiddleware((n) => n.FlexDirection = Facebook.Yoga.YogaFlexDirection.Column);
        }
    }
}
