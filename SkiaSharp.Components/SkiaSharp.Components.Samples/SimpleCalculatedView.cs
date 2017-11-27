namespace SkiaSharp.Components.Samples
{
    public class SimpleCalculatedView : SimpleView
    {
        public SimpleCalculatedView()
        {
            this.AddViews(this.Title, this.Description, this.Separator, this.Image);
        }

        public override void Layout(SKRect frame)
        {
            base.Layout(frame);

            this.Title.Frame = SKRect.Create(frame.Location, this.Title.Measure(frame.Size));

            var y = this.Title.Frame.Bottom + 5;
            this.Separator.Frame = SKRect.Create(0, y, frame.Width, 5);

            y = this.Separator.Frame.Bottom + 5;
            var area = new SKSize(frame.Width, frame.Height - y);
            this.Description.Frame = SKRect.Create(new SKPoint(frame.Left, y), this.Description.Measure(area));

            y = this.Description.Frame.Bottom + 5;
            this.Image.Frame = SKRect.Create(0, y, frame.Width, frame.Height - y);
        }
    }
}
