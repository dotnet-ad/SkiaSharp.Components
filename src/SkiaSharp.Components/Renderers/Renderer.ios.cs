﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using SkiaSharp.Views.iOS;
using UIKit;

namespace SkiaSharp.Components
{
    public class Renderer : SKCanvasView
    {
        public Renderer()
        {
            this.PaintSurface += OnPaint;
        }

        private View view;

        private SKSize size;

        public View View
        {
            get => this.view;
            set
            {
                if(this.view != null)
                {
                    this.view.Invalidated -= OnViewInvalidated; 
                }

                this.view = value;
                this.size = SKSize.Empty;

                if (this.view != null)
                {
                    this.view.Invalidated += OnViewInvalidated; // TODO Weak listener
                    this.view.Invalidate();
                }
            }
        }

        private void OnViewInvalidated(object sender, EventArgs e)
        {
            this.InvokeOnMainThread(() => {
                // manipulate UI controls
               
                Density.Global = (float)UIScreen.MainScreen.Scale;

                if(this.View != null)
                {
                    var newSize = new SKSize((float)this.Bounds.Size.Width, (float)this.Bounds.Size.Height);
                    Debug.WriteLine($"<{this.View.GetType().Name} ({this.View.Name} - {this.GetHashCode()})> Invalidated start");
                    if (this.size != newSize || this.view.NeedsLayout)
                    {
                        Debug.WriteLine($"<{this.View.GetType().Name} ({this.View.Name} - {this.GetHashCode()})> \tLayouting...");
                        this.size = newSize;
                        this.view.Layout(SKRect.Create(SKPoint.Empty, ToPlatform(this.size)));
                    }
                    Debug.WriteLine($"<{this.View.GetType().Name} ({this.View.Name} - {this.GetHashCode()})> \tSize : {this.size}");
                    this.SetNeedsDisplayInRect(this.Bounds);
                    Debug.WriteLine($"<{this.View.GetType().Name} ({this.View.Name} - {this.GetHashCode()})> Invalidated end");
                }
            });
        }

        private void OnPaint(object sender, SKPaintSurfaceEventArgs e)
        {
            e.Surface.Canvas.Clear(SKColors.White);
            Debug.WriteLine($"<{this.View.GetType().Name} ({this.View.Name} - {this.GetHashCode()})> Rendering {this.view.AbsoluteFrame}");
            this.view.Render(e.Surface.Canvas);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            this.OnViewInvalidated(this, EventArgs.Empty);
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

        private SKPoint FromPlatform(SKPoint point)
        {
            return new SKPoint(point.X / Density.Global, point.Y / Density.Global);
        }

        private SKSize FromPlatform(SKSize point)
        {
            return new SKSize(point.Width / Density.Global, point.Height / Density.Global);
        }

        private SKPoint ToPlatform(SKPoint point)
        {
            return new SKPoint(point.X * Density.Global, point.Y * Density.Global);
        }

        private SKSize ToPlatform(SKSize point)
        {
            return new SKSize(point.Width * Density.Global, point.Height * Density.Global);
        }
    }
}
