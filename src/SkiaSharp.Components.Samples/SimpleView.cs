namespace SkiaSharp.Components.Samples
{
    public class SimpleView : View
    {
        public Label Title { get; }

        public Label Description { get; }

        public View Separator { get; }

        public Image Image { get; }

        public Path Icon { get; }

        public SimpleView()
        {
            this.BackgroundBrush = new ColorBrush(SKColors.LightGray);

            this.Title = new Label
            {
                TextSize = 40,
                Text = "Title of the view"
            };

            this.Description = new Label
            {
                TextSize = 15,
                BackgroundBrush = new ColorBrush(SKColors.White),
                CornerRadius = 50,
                ShadowSize = new SKSize(4,4),
                Text = "Nam ut imperdiet nibh. Ut sollicitudin varius nibh, id ornare tortor convallis sed. Morbi volutpat, lacus efficitur volutpat lacinia, nibh velit ultricies neque, vel faucibus tellus neque at nibh. Nullam vitae tincidunt metus. Vestibulum nec nisl quis lorem tincidunt maximus eu vel lectus. Proin posuere augue molestie imperdiet scelerisque. Phasellus quis suscipit neque."
            };

            this.Separator = new Label
            {
                BackgroundBrush = new ColorBrush(SKColors.Black),
            };

            this.Image = new Image
            {
                Source = "https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png",
            };

            this.Icon = new Path
            {
                Source = IconPath.ArrowUp,
                StrokeSize = 5,
                ViewBox = SKRect.Create(0, 0, 24, 24),
            };
        }
    }
}
