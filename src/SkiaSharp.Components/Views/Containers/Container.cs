using System.Collections.Generic;
using System.Linq;

namespace SkiaSharp.Components
{
    public abstract class Container : View
    {
        private List<View> children = new List<View>();

        public virtual IEnumerable<View> Children => this.children;

        public virtual void AddView(View subview)
        {
            this.children.Add(subview);
            subview.Parent = this;
            this.Invalidate();
        }

        public virtual void RemoveView(View subview)
        {
            this.children.Remove(subview);
            subview.Parent = null;
            this.Invalidate();
        }

        public override void Layout(SKRect available)
        {
            base.Layout(available);
            this.LayoutChildren(this.LayoutFrame);
        }

        public override bool Touch(Touch[] touches) => this.Children.Any(x => x.Touch(touches));

        public override void Render(SKCanvas canvas) 
        {
            foreach (var child in this.Children)
            {
                child.Render(canvas);
            }
        }

        protected abstract void LayoutChildren(SKRect available);
    }
}
