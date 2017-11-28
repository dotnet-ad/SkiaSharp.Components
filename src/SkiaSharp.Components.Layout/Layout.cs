using System.Linq;
using Facebook.Yoga;

namespace SkiaSharp.Components.Layout
{
    public class Layout : YogaNode
    {
        public Layout(View view)
        {
            this.view = view;
            this.view.Invalidated += OnViewInvalidated; // TODO weak
        }

        private void OnViewInvalidated(object sender, System.EventArgs e)
        {
            if (this.IsMeasureDefined)
                this.MarkDirty();
        }

        protected View view;

        public void Apply()
        {
            view.Frame = SKRect.Create(this.LayoutX, this.LayoutY, this.LayoutWidth, this.LayoutHeight);

            foreach (var child in this.OfType<Layout>())
            {
                child.Apply();
            }
        }

        public void AddViews(params Layout[] children)
        {
            foreach (var child in children)
            {
                this.AddView(child);
            }
        }

        public void AddView(Layout child)
        {
            this.AddChild(child);
            this.view.AddView(child.view);
        }

        public T AddView<T>(Layout<T> child) where T : View
        {
            this.AddView((Layout)child);
            return child.View;
        }

        public bool AutoSize
        {
            set 
            {
                if(value)
                {
                    this.SetMeasureFunction(new MeasureFunction(SelfSize));
                }
                else
                {
                    this.SetMeasureFunction(null);
                }
            }
        }

        private YogaSize SelfSize(YogaNode item, float width, YogaMeasureMode wmode, float height, YogaMeasureMode hmode)
        {
            if(item is Layout layout)
            {
                var measured = layout.view.Measure(new SKSize(width, height));
                width = measured.Width;
                height = measured.Height;
            }

            return new YogaSize() { width = width, height = height };
        }
    }

    public class Layout<T> : Layout
        where T : View
    {
        public Layout(T view) : base(view) { }

        public T View => (T)this.view;
    }
}
