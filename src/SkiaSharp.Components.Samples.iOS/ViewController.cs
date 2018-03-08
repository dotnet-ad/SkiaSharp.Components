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

            var view = new FlexSample();
            var renderer = new Renderer(view.Build());
            this.View = renderer;
        }
    }
}
