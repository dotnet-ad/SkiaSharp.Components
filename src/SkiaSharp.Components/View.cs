using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkiaSharp.Components
{
    public class View 
    {
        #region Constants

        public static readonly SKColor DefaultShadowColor = SKColors.Black.WithAlpha(30);

        public static readonly IBrush DefaultBorderBrush = new ColorBrush(SKColors.Black);

        public static readonly SKSize DefaultShadowSize = new SKSize(0,0);

        public const int InvalidateTrottle = 10;

        #endregion

        #region Fields

        private bool isInvalidated;

        private IBrush backgroundBrush;

        private SKColor shadowColor = DefaultShadowColor;

        private IBrush borderBrush = DefaultBorderBrush;

        private float borderSize = 0;

        private SKRect frame;

        private bool clipBounds = true;

        private float cornerRadius;

        private SKSize shadowSize = DefaultShadowSize;

        private SKPoint shadowOffset;

        private View parent;

        private List<View> children = new List<View>();

        #endregion

        #region Events

        public event EventHandler Invalidated;

        #endregion

        public View Parent =>  this.parent;

        public SKRect AbsoluteFrame => this.Parent == null ? this.Frame : SKRect.Create(
            this.Parent.Frame.Left + this.Frame.Left,
            this.Parent.Frame.Top + this.Frame.Top,
            this.Frame.Size.Width,
            this.Frame.Size.Height);


        public SKRect Frame
        {
            get => this.frame;
            set 
            {
                if (this.frame != value)
                {
                    this.frame = value;
                    this.Layout(value);
                    this.Invalidate();
                }
            }
        }

        public float CornerRadius
        {
            get => this.cornerRadius;
            set => this.SetAndInvalidate(ref this.cornerRadius, value);
        }

        public SKSize ShadowSize
        {
            get => this.shadowSize;
            set => this.SetAndInvalidate(ref this.shadowSize, value);
        }

        public SKPoint ShadowOffset
        {
            get => this.shadowOffset;
            set => this.SetAndInvalidate(ref this.shadowOffset, value);
        }

        public IBrush BackgroundBrush
        {
            get => this.backgroundBrush;
            set => this.SetAndInvalidate(ref this.backgroundBrush, value);
        }

        public IBrush BorderBrush
        {
            get => this.borderBrush;
            set => this.SetAndInvalidate(ref this.borderBrush, value);
        }

        public float BorderSize
        {
            get => this.borderSize;
            set => this.SetAndInvalidate(ref this.borderSize, value);
        }

        public SKColor ShadowColor
        {
            get => this.shadowColor;
            set => this.SetAndInvalidate(ref this.shadowColor, value);
        }

        public bool ClipBounds
        {
            get => this.clipBounds;
            set => this.SetAndInvalidate(ref this.clipBounds, value);
        }

        public IEnumerable<View> Children => this.children;

        public virtual SKSize Measure(SKSize available) => available;

        public void Render(SKCanvas canvas) 
        {
            var absolute = this.AbsoluteFrame;

            var roundedRect = new SKPath();
            roundedRect.AddRoundedRect(absolute, this.CornerRadius, this.CornerRadius);

            // Shadow
            if(this.ShadowSize.Width > 0 || this.ShadowSize.Height > 0)
            {
                using (var filter = SKImageFilter.CreateDropShadow(this.ShadowOffset.X, this.ShadowOffset.Y, this.ShadowSize.Width, this.ShadowSize.Height, this.ShadowColor, SKDropShadowImageFilterShadowMode.DrawShadowOnly))
                using (var paint = new SKPaint
                {
                    ImageFilter = filter,
                    IsAntialias = true,
                })
                {
                    canvas.DrawPath(roundedRect, paint);
                }
            }

            // Border
            if (this.BorderSize > 0)
            {
                using (var paint = new SKPaint
                {
                    Style = SKPaintStyle.Stroke,
                    StrokeWidth = this.BorderSize,
                    IsAntialias = true,
                })
                using(var brush = this.BorderBrush.Apply(canvas, paint, frame))
                {
                    canvas.DrawPath(roundedRect, paint);
                }
            }

            // Clip region
            if (this.ClipBounds)
            {
                canvas.Save();
                canvas.ClipPath(roundedRect);
            }

            this.Render(canvas, absolute);

            foreach (var child in this.children)
            {
                child.Render(canvas);
            }

            if (this.ClipBounds)
            {
                canvas.Restore();
            }
        }

        public virtual void Layout(SKRect frame) { }

        protected virtual void Render(SKCanvas canvas, SKRect frame)
        {
            if (this.BackgroundBrush != null)
            {
                using (var paint = new SKPaint()
                {
                    Style = SKPaintStyle.Fill,
                })

                using(var brush = this.BackgroundBrush.Apply(canvas, paint, frame))
                {
                    if(this.CornerRadius > 0)
                    {
                        paint.IsAntialias = true;
                        canvas.DrawRoundRect(frame, this.CornerRadius, this.CornerRadius, paint);
                    }
                    else
                    {
                        canvas.DrawRect(frame, paint);
                    }
                }
            }
        }

        public async void Invalidate()
        {
            if (!this.isInvalidated)
            {
                this.isInvalidated = true;
                await Task.Delay(InvalidateTrottle);

                this.Invalidated?.Invoke(this, EventArgs.Empty);

                // ATM all tree is invalidated
                var root = this.Parent;
                while (root?.Parent != null)
                    root = root.Parent;

                if(root != null && root != this)
                    root.Invalidate();

                this.isInvalidated = false;
            }
        }

        public void AddViews(params View[] children)
        {
            foreach (var child in children)
            {
                this.AddView(child);
            }
        }

        public void AddView(View child)
        {
            if (child.Parent != null)
                throw new InvalidOperationException("Added view already has a parent");

            child.parent = this;
            this.children.Add(child);
            this.Invalidate();
        }

        public void RemoveView(View child)
        {
            if (child.Parent != this)
                throw new InvalidOperationException("Removed view isn't a child of this view");

            child.parent = null;
            this.children.Remove(child);
            this.Invalidate();
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

        public virtual bool Touch(Touch[] touches)
        { 
            foreach (var child in this.children)
            {
                if (child.Touch(touches))
                    return true;
            }

            return false;
        }
    }
}
