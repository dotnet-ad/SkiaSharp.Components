using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SkiaSharp.Components
{
    public class View 
    {
        #region Constants

        public const int InvalidateTrottle = 10;

        #endregion

        public View Parent { get; set; }

        public virtual SKRect LayoutFrame { get; set; }

        public bool IsInvalidated { get; private set; }

        public bool NeedsLayout { get; set; } = true;

        #region Events

        public event EventHandler Invalidated;

        #endregion

        #region Fields

        private SKRect lastLayout;

        #endregion

        public string Name { get; set; }

        public virtual SKRect AbsoluteFrame
        {
            get
            {
                var frame = this.Parent?.AbsoluteFrame ?? SKRect.Empty;
                var point = frame.Location + this.LayoutFrame.Location;
                var size = this.LayoutFrame.Size;
                return SKRect.Create(point, size);
            }
        }

        public virtual void Layout(SKRect available)
        {
            this.LayoutFrame = available;
            this.NeedsLayout = false;
        }

        public virtual bool LayoutIfNeeded(SKRect available)
        {
            if(lastLayout != available || this.NeedsLayout)
            {
                Debug.WriteLine($"[{this.GetType().Name}:{this.Name}] Layout in {available}");
                this.Layout(available);
                this.lastLayout = available;
                this.Invalidate();
                return true;
            }

            return false;
        }

        public virtual void Render(SKCanvas canvas) {}

        public async void Invalidate()
        {
            if (!this.IsInvalidated)
            {
                this.IsInvalidated = true;
                await Task.Delay(InvalidateTrottle);

                this.Invalidated?.Invoke(this, EventArgs.Empty);

                // ATM all tree is invalidated
                var root = this.Parent;
                while (root?.Parent != null)
                    root = root.Parent;

                if (root != null && root != this)
                    root.Invalidate();

                this.IsInvalidated = false;
            }
        }

        protected bool SetAndInvalidate<T>(ref T field, T value)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                this.Invalidate();
                return true;
            }

            return false;
        }

        protected bool SetAndInvalidate<T>(Func<T> getter, Action<T> setter, T value)
        {
            if (!EqualityComparer<T>.Default.Equals(getter(), value))
            {
                setter(value);
                this.Invalidate();
                return true;
            }

            return false;
        }

        public virtual bool Touch(Touch[] touches) => false;
    }
}
