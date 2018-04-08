using System;
using Android.Support.V7.Widget;
using Android.Content;
using Android.Views;

namespace SkiaSharp.Components
{
    public class BuilderRenderer : RecyclerView
    {
        public class BuilderViewHolder : ViewHolder
        {
            public BuilderViewHolder(Context context) : base(new Renderer(context))
            {
                this.renderer = this.ItemView as Renderer;
            }

            private Renderer renderer;

            public View View 
            {
                get => this.renderer.View;
                set => this.renderer.View = value;
            }
        }

        public class BuilderAdapter : Adapter
        {
            public BuilderAdapter(Builder builder)
            {
                this.builder = builder;
            }

            private Builder builder;

            public override int ItemCount => builder.ItemCount;

            public override void OnBindViewHolder(ViewHolder holder, int position)
            {
                var cell = holder.ItemView as Renderer;
                var view = this.builder.Build(position);
                var measure = this.builder.Measure(position);
                float height = 0;

                switch (measure.Mode)
                {
                    case MeasurementMode.Fixed:
                        height = measure.Size;
                        break;
                    default:
                        view.Layout(SKRect.Create(SKPoint.Empty, new SKSize(holder.ItemView.MeasuredWidth / Density.Global, float.MaxValue)));
                        height = view.AbsoluteFrame.Height;
                        break;
                }

                var layoutParams = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                layoutParams.Height = (int)(height * Density.Global);
                holder.ItemView.LayoutParameters = layoutParams;

            }

            public override int GetItemViewType(int position) => 0;

            public override ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
            {
                return new BuilderViewHolder(parent.Context);
            }
        }

        public BuilderRenderer(Builder builder, Context context) : base(context)
        {
            var layout = new LinearLayoutManager(this.Context);
            this.SetLayoutManager(layout);
            this.SetAdapter(this.adapter = new BuilderAdapter(builder));
            this.SetBackgroundColor(Android.Graphics.Color.Red);
            this.builder = builder;
            this.builder.Invalidated += OnViewInvalidated; // TODO Weak listener
        }

        private BuilderAdapter adapter;

        private Builder builder;

        private SKRect size;

        private void OnViewInvalidated(object sender, EventArgs e)
        {
            var displayMetrics = this.Context.Resources.DisplayMetrics;
            Density.Global = displayMetrics.Density;

            this.builder.Layout(this.size);
            this.Invalidate();
        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged(w, h, oldw, oldh);

            if (w != oldw || h != oldh)
            {
                this.size = SKRect.Create(SKPoint.Empty, new SKSize(w, h));
            }
        }

        private static SKSize ToPlatform(SKSize point)
        {
            return new SKSize(point.Width * Density.Global, point.Height * Density.Global);
        }

        private static float FromPlatform(int value)
        {
            return value / Density.Global;
        }
    }
}
