using System;
using System.Diagnostics;
using SkiaSharp.Views.iOS;

namespace SkiaSharp.Components.Samples.iOS
{
    public class Renderer : SKCanvasView
    {
        public Renderer(View view)
        {
            this.view = view;
            this.PaintSurface += OnPaint;
            view.Invalidated += OnViewInvalidated; // TODO Weak listener
        }

        private View view;

        private void OnViewInvalidated(object sender, EventArgs e)
        {
            Debug.WriteLine("<OnViewInvalidated start>");
            this.view.Layout(this.view.Frame);
            this.SetNeedsDisplayInRect(this.Bounds);
            Debug.WriteLine("<OnViewInvalidated end>");
        }

        private void OnPaint(object sender, SKPaintSurfaceEventArgs e)
        {
            e.Surface.Canvas.Clear(SKColors.White);
            this.view.Render(e.Surface.Canvas);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            Debug.WriteLine("<LayoutSubviews start>");
            this.view.Frame = SKRect.Create(0, 0, (float)this.Bounds.Size.Width * 2, (float)this.Bounds.Size.Height * 2);
            Debug.WriteLine("<LayoutSubviews end>");
        }
    }
}
