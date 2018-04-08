using System;
using System.IO;
using System.Net.Http;
namespace SkiaSharp.Components.Samples
{
    public abstract class SampleBase
    {
        #region Properties

        public Label Title { get; }

        public Label Description { get; }

        public Box Image { get; }

        public Box Box { get; }

        public Path Icon { get; }

        #endregion

        public SampleBase()
        {
            this.Title = new Label
            {
                TextSize = 30,
                Text = "Title of the view",
                VerticalAlignment = Alignment.Center,
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
                        ForegroundBrush = new ColorBrush(new SKColor(0xFFF44336)),
                        Decorations = TextDecoration.Bold,
                        Text = "id ornare tortor convallis sed"
                    },
                    new Span
                    {
                        Text = ". Morbi volutpat, lacus efficitur volutpat lacinia, nibh velit ultricies neque, vel faucibus tellus neque at nibh. Nullam vitae tincidunt metus. Vestibulum nec nisl quis lorem tincidunt maximus eu vel lectus. Proin posuere augue molestie imperdiet scelerisque. Phasellus quis suscipit neque."
                    },
                },
            };

            var gradient = new GradientBrush(new SKPoint(0, 0), new SKPoint(0, 1), new[]
            {
                new Tuple<float, SKColor>(0, new SKColor(255,255,255,255)),
                new Tuple<float, SKColor>(1, new SKColor(238,238,238,255)),
            });

            var shadow = new Shadow()
            {
                Blur = new SKPoint(10, 10),
                Color = SKColors.Black.WithAlpha(80),
            };

            this.Image = new Box()
            {
                Fill = new ColorBrush(SKColors.LightGray),
                CornerRadius = 5.0f,
                Shadow = shadow,
            };

            this.Box = new Box()
            {
                Fill = gradient,
                CornerRadius = 5.0f,
                Shadow = shadow,
            };

            var iconGradient = new GradientBrush(new SKPoint(0, 0), new SKPoint(1, 1), new[]
            {
                new Tuple<float, SKColor>(0, new SKColor(0xFFF44336)),
                new Tuple<float, SKColor>(1, new SKColor(0xFF3F51B5)),
            });

            this.Icon = new Path
            {
                Source = IconPath.Aperture,
                ViewBox = SKRect.Create(0, 0, 24, 24),
                Stroke = new Stroke()
                {
                    Size = 5,
                    Brush = iconGradient,
                },
            };

            this.LoadImage();
        }

        private async void LoadImage()
        {
            var client = new HttpClient();
            using(var response = await client.GetStreamAsync("https://source.unsplash.com/random"))
            {
                var memory = new MemoryStream();
                response.CopyTo(memory);
                this.Image.Fill = new ImageBrush(() => {
                    var copy = new MemoryStream();
                    memory.Seek(0, SeekOrigin.Begin);
                    memory.CopyTo(copy);
                    copy.Seek(0, SeekOrigin.Begin);
                    return copy;
                }, 1.0f);
            }
           
        }

        public abstract View Build();
    }
}
