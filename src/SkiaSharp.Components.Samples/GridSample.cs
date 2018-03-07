namespace SkiaSharp.Components.Samples
{
    public class GridSample : SampleBase
    {
        public override View Build()
        {
            var result = new Grid();

            result.ColumnDefinitions = new[]
            {
                Grid.Definition.Points(100),
                Grid.Definition.Stars(1),
            };

            result.RowDefinitions = new[]
            {
                Grid.Definition.Points(100),
                Grid.Definition.Points(200),
                Grid.Definition.Stars(1),
            };

            result.AddView(this.Icon, 0, 0);
            result.AddView(this.Title, 1, 0);
            result.AddView(this.Description, 0, 1, 2);
            result.AddView(this.Image, 0, 2, 2);
            return result;
        }
    }
}
