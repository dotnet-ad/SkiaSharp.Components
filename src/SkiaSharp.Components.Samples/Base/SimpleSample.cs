namespace SkiaSharp.Components.Samples
{
    public class SimpleSample : SampleBase
    {
        public override View Build()
        {
            var result = new Absolute();
            result.AddView(this.Title, (available) => SKRect.Create(10, 10, available.Width - 20, 40));
            result.AddView(this.Description, (available) => SKRect.Create(10, 50, available.Width - 20, 50));
            result.AddView(this.Image, (available) => SKRect.Create(10, 100, available.Width - 20, 100));
            result.AddView(this.Icon, (available) => SKRect.Create(10, 210, 50, 50));
            return result;
        }
    }
}
