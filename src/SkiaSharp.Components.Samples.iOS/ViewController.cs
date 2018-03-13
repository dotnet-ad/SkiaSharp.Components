using System;
using UIKit;

namespace SkiaSharp.Components.Samples.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Basic
            //var view = new FlexSample();
            //var renderer = new Renderer();
            //renderer.View = view.Build();
            //this.View = renderer;

            // Builder
            var renderer = new BuilderRenderer(new BuilderSample());

            // Markup
            //var renderer = new Renderer();
            //renderer.View = new Test.Sample(BuilderSample.Items[0]);

            this.View = renderer;
        }
    }
}
