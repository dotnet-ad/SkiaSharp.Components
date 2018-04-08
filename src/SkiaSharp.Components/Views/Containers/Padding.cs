using System;

namespace SkiaSharp.Components
{
    public class Padding : View
    {
        public View Child
        {
            get => this.child;
            set => this.SetAndInvalidate(ref this.child, value);
        }

        public Margin Margin
        {
            get => this.margin;
            set => this.SetAndInvalidate(ref this.margin, value);
        }

        private Margin margin;

        private View child;

        public override void Layout(SKRect available)
        {
            base.Layout(available);

            if(this.Child != null)
            {
                var left = available.Left + (this.Margin?.Left ?? 0);
                var top = available.Top + (this.Margin?.Top ?? 0);
                var width = Math.Max(0,available.Width - (this.Margin?.Right ?? 0) - (this.Margin?.Left ?? 0));
                var height = Math.Max(0,available.Height - (this.Margin?.Top ?? 0) - (this.Margin?.Bottom ?? 0));

                var inner = SKRect.Create(left, top, width, height);
                this.Child.LayoutIfNeeded(inner);
            }
        }

        public override void Render(SKCanvas canvas)
        {
            base.Render(canvas);
            this.Child?.Render(canvas);
        }
    }
}
