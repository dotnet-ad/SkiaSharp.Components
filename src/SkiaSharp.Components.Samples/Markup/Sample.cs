using SkiaSharp.Components;

namespace Test
{
    public partial class Sample
    {
        public Sample()
        {
            this.Initialize();

            this.title.Text = "Hello world!";
            this.subtitle.Text = "Hey this is a subtitle!";
            this.description.Text = "Praesent elementum vestibulum erat. Aliquam malesuada mi sed quam eleifend, id fringilla urna porttitor. Aenean nec neque interdum, volutpat sapien at, dignissim est.";
            this.icon.Source = IconPath.Aperture;
        }
    }
}
