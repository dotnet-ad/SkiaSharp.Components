using System.IO;
using System.Net.Http;
namespace SkiaSharp.Components.Samples
{
    public abstract class SampleBase
    {
        public Label Title { get; }

        public Label Description { get; }

        public Box Image { get; }

        public Path Icon { get; }

        public SampleBase()
        {
            this.Title = new Label
            {
                TextSize = 40,
                Text = "Title of the view"
            };

            this.Description = new Label
            {
                TextSize = 16,
                Spans = new[]
                {
                    new Span
                    {
                        Text = "Nam ut imperdiet nibh. Ut sollicitudin varius nibh,"
                    },
                    new Span
                    {
                        ForegroundBrush = new ColorBrush(SKColors.Red),
                        Decorations = TextDecoration.Bold,
                        Text = "id ornare tortor convallis sed"
                    },
                    new Span
                    {
                        Text = ". Morbi volutpat, lacus efficitur volutpat lacinia, nibh velit ultricies neque, vel faucibus tellus neque at nibh. Nullam vitae tincidunt metus. Vestibulum nec nisl quis lorem tincidunt maximus eu vel lectus. Proin posuere augue molestie imperdiet scelerisque. Phasellus quis suscipit neque."
                    },
                },
            };

            this.Image = new Box()
            {
                Fill = new ColorBrush(SKColors.LightGray),
            };

            this.Icon = new Path
            {
                Source = IconPath.ArrowUp,
                ViewBox = SKRect.Create(0, 0, 24, 24),
                Stroke = new Stroke()
                {
                    Size = 5,
                    Brush = new ColorBrush(SKColors.Blue),
                },
            };

            this.LoadImage();
        }

        private async void LoadImage()
        {
            var client = new HttpClient();
            using(var response = await client.GetStreamAsync("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"))
            {
                var memory = new MemoryStream();
                response.CopyTo(memory);
                this.Image.Fill = new ImageBrush(() => {
                    memory.Seek(0, SeekOrigin.Begin);
                    return memory;
                }, 1.0f);
            }
           
        }

        public abstract View Build();
    }
}
