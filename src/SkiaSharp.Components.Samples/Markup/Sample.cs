using SkiaSharp.Components.Samples;

namespace Test
{
    public partial class Sample
    {
        public Sample(Item item)
        {
            this.Initialize();

            this.title.Text = item.Title;
            this.subtitle.Text = "Hey this is a subtitle!";
            this.description.Text = item.Description;
            this.icon.Source = item.Icon.Path;
            this.image.Source = $"http://via.placeholder.com/400?+text={item.Title}";
        }
    }
}
