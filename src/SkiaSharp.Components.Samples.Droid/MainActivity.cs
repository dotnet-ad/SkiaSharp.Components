using Android.App;
using Android.OS;

namespace SkiaSharp.Components.Samples.Droid
{
    [Activity(Label = "Components for SkiaSharp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var view = new GridSample();
            var renderer = new Renderer(view.Build(), this);
            SetContentView(renderer);
        }
    }
}

