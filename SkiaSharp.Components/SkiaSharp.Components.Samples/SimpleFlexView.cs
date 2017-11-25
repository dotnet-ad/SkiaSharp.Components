using System.Threading.Tasks;
using SkiaSharp.Components.Layout;

namespace SkiaSharp.Components.Samples
{
    public class SimpleFlexView : FlexView
    {
        public Label Title { get; }

        public Label Description { get; }

        public View Separator { get; }

        public Image Image { get; }

        public Path Icon { get; }

        public SimpleFlexView()
        {
            this.Root.Padding = 10;
            this.BackgroundColor = SKColors.LightGray;
     
            this.Title = this.AddView(new Layout<Label>(new Label
            {
                TextSize = 40,
                Text = "Title of the view"
            })
            {
                AutoSize = true,
            });

            this.Separator = this.AddView(new Layout<View>(new View
            {
                BackgroundColor = SKColors.Black,
                CornerRadius = 2,
            })
            {
                Height = 4,
                AlignSelf = Facebook.Yoga.YogaAlign.Stretch,
                MarginTop = 10,
                MarginBottom = 10,
            });

            var row = new Layout<View>(new View()
            {
                ClipBounds = false,
            })
            {
                FlexDirection = Facebook.Yoga.YogaFlexDirection.Row,
            };
            this.AddView(row);

            this.Description = row.AddView(new Layout<Label>(new Label
            {
                TextSize = 15,
                BackgroundColor = SKColors.White,
                CornerRadius = 50,
                ShadowSize = new SKSize(4, 4),
                BorderSize = 4,
                BorderColor = SKColors.Red,
                Text = "Nam ut imperdiet nibh. Ut sollicitudin varius nibh, id ornare tortor convallis sed. Morbi volutpat, lacus efficitur volutpat lacinia, nibh velit ultricies neque, vel faucibus tellus neque at nibh. Nullam vitae tincidunt metus. Vestibulum nec nisl quis lorem tincidunt maximus eu vel lectus. Proin posuere augue molestie imperdiet scelerisque. Phasellus quis suscipit neque."
            })
            {
                Flex = 1,
                AutoSize = true,
            });

            var source = new SKPath();
            source.AddCircle(20, 20, 20);
            source.AddPoly(new [] { new SKPoint(20, 0), new SKPoint(0,20), new SKPoint(40, 20), new SKPoint(20, 40) }, true);
            this.Icon = row.AddView(new Layout<Path>(new Path
            {
                Source = source,
                StrokeSize = 5,
            })
            {
                AlignSelf = Facebook.Yoga.YogaAlign.Center,
                MarginLeft = 10,
                Width = 100,
                Height = 100,
            });

            this.Image = this.AddView(new Layout<Image>(new Image
            {
                Source = "https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png",
            })
            {
                Flex = 1,
                MarginTop = 10,
            });

            this.Update();
        }

        private async void Update()
        {
            for (int i = 0; i < 50; i++)
            {
                await Task.Delay(1000);
                this.Description.Text += " new words";
            }
        }
    }
}
