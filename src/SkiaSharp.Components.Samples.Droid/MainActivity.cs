using Android.App;
using Android.OS;
using Test;

namespace SkiaSharp.Components.Samples.Droid
{
    [Activity(Label = "Components for SkiaSharp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //var renderer = new Renderer(this);
            //renderer.View = new Sample();

            // Builder
            var renderer = new BuilderRenderer(new BuilderSample(), this);

            SetContentView(renderer);
        }
    }
}

