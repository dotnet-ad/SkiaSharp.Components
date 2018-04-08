using System;
using System.Collections.Generic;
using System.Diagnostics;
using Android.Content;
using Android.Views;
using SkiaSharp.Views.Android;

namespace SkiaSharp.Components
{
    public class Renderer : SKCanvasView
    {
        public Renderer(Context context) : base(context)
        {
            this.PaintSurface += OnPaint;
        }

        #region Fields

        private View view;

        private float lastWidth;

        private SKRect size;

        private bool isInvalidated;

        #endregion

        #region Properties

        public View View
        {
            get => this.view;
            set
            {
                if (this.view != null)
                {
                    this.view.Invalidated -= OnViewInvalidated;
                }

                this.view = value;

                if (this.view != null)
                {
                    this.view.Invalidated += OnViewInvalidated; // TODO Weak listener
                }

                this.isInvalidated = true;
                this.Invalidate();
            }
        }

        #endregion

        private void OnViewInvalidated(object sender, EventArgs e)
        {
            this.Post(() =>
            {
                if(this.view != null)
                {
                    this.isInvalidated = true;
                    LayoutView(this.MeasuredWidth, this.MeasuredHeight);
                    this.Invalidate();
                }
            });
        }

        private void LayoutView(float w, float h)
        {
            if (w != lastWidth || this.view.NeedsLayout)
            {
                this.lastWidth = w;

                var displayMetrics = this.Context.Resources.DisplayMetrics;
                Density.Global = displayMetrics.Density;

                this.size = SKRect.Create(SKPoint.Empty, new SKSize(w, h));
                Debug.WriteLine($"Layout {this.size} ...");
                this.view?.LayoutIfNeeded(this.size);
            }
        }

        private void OnPaint(object sender, SKPaintSurfaceEventArgs e)
        {
            if(this.isInvalidated)
            {
                e.Surface.Canvas.Clear(SKColors.White);
                Debug.WriteLine($"Paint!");
                this.view?.Render(e.Surface.Canvas);
                this.isInvalidated = false;
            }
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            var wMode = MeasureSpec.GetMode(widthMeasureSpec);
            var hMode = MeasureSpec.GetMode(heightMeasureSpec);

            var totalWidth = MeasureSpec.GetSize(widthMeasureSpec);
            var totalHeight = MeasureSpec.GetSize(heightMeasureSpec);

            if(this.view != null)
            {
                var w = wMode == MeasureSpecMode.Unspecified ? float.MaxValue : totalWidth;
                var h = hMode == MeasureSpecMode.Unspecified ? float.MaxValue : totalHeight;

                this.LayoutView(w, h);
            
                var mw = (int)this.View.LayoutFrame.Width;
                var mh = (int)this.View.LayoutFrame.Height;

                this.SetMeasuredDimension(mw, mh);
            }
            else
            {
                this.SetMeasuredDimension(0, 0);
            }
        }

        #region Touches

        public Dictionary<int, Touch> touches = new Dictionary<int, Touch>();

        public override bool OnTouchEvent(MotionEvent e)
        {
            var action = e.ActionMasked;
            var index = e.ActionIndex;
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
                this.view?.Touch(new [] { current });
                return true;
            }
            else if(action == MotionEventActions.Move)
            {
                var current = this.touches[index];
                current.Position = position;
                current.State = TouchState.Moved;
                this.view?.Touch(new[] { current });
                return true;
            }
            else if (action == MotionEventActions.Cancel || action == MotionEventActions.Up)
            {
                var current = this.touches[index];
                this.touches.Remove(index);
                current.Position = position;
                current.State = TouchState.Ended;
                this.view?.Touch(new[] { current });
                return true;
            }

            return base.OnTouchEvent(e);
        }

        #endregion
    }
}
