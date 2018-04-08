using System;
using System.Collections.Generic;
using System.Diagnostics;
using SkiaSharp.Views.iOS;
using UIKit;

namespace SkiaSharp.Components.Layout.iOS
{
    public class ViewRenderer : SKCanvasView
    {
        public ViewRenderer(View view)
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
            this.view.Frame = SKRect.Create(SKPoint.Empty, ToPlatform(new SKSize((float)this.Bounds.Size.Width , (float)this.Bounds.Size.Height)));
            Debug.WriteLine("<LayoutSubviews end>");
        }

        #region Touches


        public Dictionary<UITouch, Touch> touchState = new Dictionary<UITouch, Touch>();

        public override void TouchesBegan(Foundation.NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);

            var changes = new List<Touch>();

            foreach (UITouch touch in touches)
            {
                var position = ToPlatform(touch.LocationInView(this).ToSKPoint());
                var current = new Touch()
                {
                    StartPosition = position,
                    Position = position,
                    State = TouchState.Began,
                };
                touchState.Add(touch, current);
                changes.Add(current);
            }

            this.view.Touch(changes.ToArray());
        }

        public override void TouchesMoved(Foundation.NSSet touches, UIEvent evt)
        {
            base.TouchesMoved(touches, evt);

            var changes = new List<Touch>();

            foreach (UITouch touch in touches)
            {
                var position = ToPlatform(touch.LocationInView(this).ToSKPoint());
                var current = touchState[touch];
                current.Position = position;
                current.State = TouchState.Moved;
                changes.Add(current);
            }

            this.view.Touch(changes.ToArray());
        }

        public override void TouchesEnded(Foundation.NSSet touches, UIEvent evt)
        {
            base.TouchesEnded(touches, evt);

            var changes = new List<Touch>();

            foreach (UITouch touch in touches)
            {
                var position = ToPlatform(touch.LocationInView(this).ToSKPoint());
                var current = touchState[touch];
                current.Position = position;
                current.State = TouchState.Ended;
                changes.Add(current);
                touchState.Remove(touch);
            }

            this.view.Touch(changes.ToArray());
        }

        public override void TouchesCancelled(Foundation.NSSet touches, UIEvent evt)
        {
            base.TouchesCancelled(touches, evt);

            var changes = new List<Touch>();

            foreach (UITouch touch in touches)
            {
                var position = ToPlatform(touch.LocationInView(this).ToSKPoint());
                var current = touchState[touch];
                current.Position = position;
                current.State = TouchState.Cancelled;
                changes.Add(current);
                touchState.Remove(touch);
            }

            this.view.Touch(changes.ToArray());
        }

        #endregion

        private float Density => 2;

        private SKPoint FromPlatform(SKPoint point)
        {
            return new SKPoint(point.X / Density, point.Y / Density);
        }

        private SKSize FromPlatform(SKSize point)
        {
            return new SKSize(point.Width / Density, point.Height / Density);
        }

        private SKPoint ToPlatform(SKPoint point)
        {
            return new SKPoint(point.X * Density, point.Y * Density);
        }

        private SKSize ToPlatform(SKSize point)
        {
            return new SKSize(point.Width * Density, point.Height * Density);
        }
    }
}
