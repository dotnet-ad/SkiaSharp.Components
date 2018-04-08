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

            var view = new FlexSample();
            var renderer = new Renderer(this);
            renderer.View = view.Build();
            SetContentView(renderer);
        }
    }
}

