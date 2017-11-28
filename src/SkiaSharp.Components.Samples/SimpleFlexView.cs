using System.Threading.Tasks;
using SkiaSharp.Components.Layout;
using System.Linq;

namespace SkiaSharp.Components.Samples
{
    public class SimpleFlexView : FlexView
    {
        public Label Title { get; }

        public Label Description { get; }

        public View Separator { get; }

        public Image Image { get; }

        public Path Icon { get; }

        public Tap Button { get; }

        public SimpleFlexView()
        {
            this.Root.Padding = 10;
            this.BackgroundBrush = new ColorBrush(SKColors.LightGray);
     
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
                BackgroundBrush = new ColorBrush(SKColors.Black),
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
                BackgroundBrush = new ColorBrush(SKColors.White),
                CornerRadius = 50,
                ShadowSize = new SKSize(4, 4),
                BorderSize = 4,
                BorderBrush = new ColorBrush(SKColors.Red),
                Text = "Nam ut imperdiet nibh. Ut sollicitudin varius nibh, id ornare tortor convallis sed. Morbi volutpat, lacus efficitur volutpat lacinia, nibh velit ultricies neque, vel faucibus tellus neque at nibh. Nullam vitae tincidunt metus. Vestibulum nec nisl quis lorem tincidunt maximus eu vel lectus. Proin posuere augue molestie imperdiet scelerisque. Phasellus quis suscipit neque."
            })
            {
                Flex = 1,
                AutoSize = true,
            });

            this.Icon = row.AddView(new Layout<Path>(new Path
            {
                Source = IconPath.ArrowUp,
                StrokeSize = 5,
                ViewBox = SKRect.Create(0,0,24,24),
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

            this.Button = this.AddView(new Layout<Tap>(new Tap()
            {
                BackgroundBrush = new ColorBrush(SKColors.DeepPink),
                CornerRadius = 5,
            })
            {
                Height = 100,
            });

            this.Button.Tapped += OnButtonTapped;
            this.Button.Pressed += (s, e) => ((Tap)s).BackgroundBrush = new ColorBrush(SKColors.LightPink);
            this.Button.Released += (s, e) => ((Tap)s).BackgroundBrush = new ColorBrush(SKColors.DeepPink);
        }

        private int currentIcon = 0;

        private string[] iconNames = typeof(IconPath).GetProperties().Select(x => x.Name).ToArray();

        private SKPath[] iconPaths = typeof(IconPath).GetProperties().Select(x => (SKPath)x.GetValue(null)).ToArray();

        void OnButtonTapped(object sender, System.EventArgs e)
        {
            currentIcon = (currentIcon + 1) % iconPaths.Length;
            this.Description.Text += $" | {iconNames[currentIcon]}";
            this.Icon.Source = iconPaths[currentIcon];
        }
    }
}
