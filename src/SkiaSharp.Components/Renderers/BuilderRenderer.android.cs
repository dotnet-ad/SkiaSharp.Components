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
                cell.View = this.builder.Build(position);
                var layoutParams = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                holder.ItemView.LayoutParameters = layoutParams;
            }

            public override int GetItemViewType(int position) => 0;

            public override ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType) => new BuilderViewHolder(parent.Context);
        }

        public BuilderRenderer(Builder builder, Context context) : base(context)
        {
            var layout = new LinearLayoutManager(this.Context);
            this.SetLayoutManager(layout);
            this.SetAdapter(this.adapter = new BuilderAdapter(builder));
            this.builder = builder;
            this.builder.Invalidated += OnViewInvalidated; // TODO Weak listener
        }

        private BuilderAdapter adapter;

        private Builder builder;

        private SKRect size;

        protected void OnViewInvalidated(object sender, EventArgs e)
        {
            var displayMetrics = this.Context.Resources.DisplayMetrics;
            Density.Global = displayMetrics.Density;

            this.size = SKRect.Create(SKPoint.Empty, new SKSize(this.MeasuredWidth, this.MeasuredHeight));
            this.builder.Layout(this.size);
            this.Invalidate();
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
