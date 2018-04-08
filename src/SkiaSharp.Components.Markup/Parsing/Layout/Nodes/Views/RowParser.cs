namespace SkiaSharp.Components
{
    public class RowParser : NodeParser
    {
        public RowParser() : base("Row")
        {
            this.WithMiddleware((n) => n.FlexDirection = Facebook.Yoga.YogaFlexDirection.Row);
        }
    }
}
