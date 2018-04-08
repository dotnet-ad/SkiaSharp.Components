using System;
using System.Collections.Generic;
using System.Diagnostics;
using Android.Content;
using Android.Views;
using SkiaSharp.Views.Android;

namespace SkiaSharp.Components.Layout.Droid
{
    public class ViewRenderer : SKCanvasView
    {
        public ViewRenderer(View view, Context context) : base(context)
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
            this.Invalidate();
            Debug.WriteLine("<OnViewInvalidated end>");
        }

        private void OnPaint(object sender, SKPaintSurfaceEventArgs e)
        {
            e.Surface.Canvas.Clear(SKColors.White);
            this.view.Render(e.Surface.Canvas);
        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged(w, h, oldw, oldh);

            if (w != oldw || h != oldh)
            {
                Debug.WriteLine("<LayoutSubviews start>");
                this.view.Frame = SKRect.Create(SKPoint.Empty, new SKSize(w, h));
                Debug.WriteLine("<LayoutSubviews end>");
            }

        }

        #region Touches

        public Dictionary<int, Touch> touches = new Dictionary<int, Components.Touch>();

        public override bool OnTouchEvent(Android.Views.MotionEvent e)
        {
            var action = e.ActionMasked;
            var index = e.ActionIndex;
            Debug.WriteLine($"ACTION:{action}");
            var coords = new MotionEvent.PointerCoords();
            e.GetPointerCoords(index, coords);
            var position = new SKPoint(coords.X, coords.Y);

            if (action == MotionEventActions.Down)
            {
                var current = new Touch()
                {
                    StartPosition = position,
                    Position = position,
                    State = TouchState.Began,
                };
                this.touches[index] = current;
                this.view.Touch(new [] { current });
                return true;
            }
            else if(action == MotionEventActions.Move)
            {
                var current = this.touches[index];
                current.Position = position;
                current.State = TouchState.Moved;
                this.view.Touch(new[] { current });
                return true;
            }
            else if (action == MotionEventActions.Cancel || action == MotionEventActions.Up)
            {
                var current = this.touches[index];
                this.touches.Remove(index);
                current.Position = position;
                current.State = TouchState.Ended;
                this.view.Touch(new[] { current });
                return true;
            }

            return base.OnTouchEvent(e);
        }

        #endregion
    }
}
