using Android.App;
using Android.Widget;
using Android.OS;
using SkiaSharp.Components.Layout.Droid;

namespace SkiaSharp.Components.Samples.Droid
{
    [Activity(Label = "SkiaSharp.Components.Samples.Droid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var view = new SimpleFlexView();
            var renderer = new ViewRenderer(view, this);
            SetContentView(renderer);
        }
    }
}

