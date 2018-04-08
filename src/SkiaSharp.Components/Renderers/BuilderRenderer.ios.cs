using System;
using System.Diagnostics;
using Foundation;
using UIKit;

namespace SkiaSharp.Components
{
    public class BuilderRenderer : UITableView
    {
        public class BuilderCell : UITableViewCell
        {
            public BuilderCell() : base(UITableViewCellStyle.Default, nameof(BuilderCell))
            {
                this.renderer = new Renderer();
                this.AddSubview(this.renderer);
                this.SelectionStyle = UITableViewCellSelectionStyle.None;
            }

            private Renderer renderer;

            public View View 
            {
                get => this.renderer.View;
                set => this.renderer.View = value;
            }

            public override void LayoutSubviews()
            {
                base.LayoutSubviews();
                this.renderer.Frame = this.Bounds;
            }
        }

        public class BuilderSource : UITableViewSource
        {
            public BuilderSource(Builder builder)
            {
                this.builder = builder;
            }

            private Builder builder;

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = (tableView.DequeueReusableCell(nameof(BuilderCell)) as BuilderCell) ?? new BuilderCell();;
                cell.View = this.builder.Build(indexPath.Row);
                return cell;
            }

            public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
            {
                Density.Global = (float)UIScreen.MainScreen.Scale;

                var measure = this.builder.Measure(indexPath.Row);

                switch (measure.Mode)
                {
                    case MeasurementMode.Fixed:
                        return measure.Size;
                    default:
                        var view = this.builder.Build(indexPath.Row);
                        view.Layout(SKRect.Create(SKPoint.Empty, new SKSize((float)tableView.Bounds.Width * Density.Global, float.MaxValue)));
                        return FromPlatform(view.AbsoluteFrame.Height);
                }
            }

            public override nint NumberOfSections(UITableView tableView) => 1;

            public override nint RowsInSection(UITableView tableview, nint section) => this.builder.ItemCount;
        }

        public BuilderRenderer(Builder builder)
        {
            this.SeparatorStyle = UITableViewCellSeparatorStyle.None;
            this.builder = builder;
            builder.Invalidated += OnViewInvalidated; // TODO Weak listener
            this.Source = new BuilderSource(this.builder);
            this.ReloadData();
        }

        private Builder builder;

        private SKSize size;

        private void OnViewInvalidated(object sender, EventArgs e)
        {
            Density.Global = (float)UIScreen.MainScreen.Scale;

            var newSize = new SKSize((float)this.Bounds.Size.Width, (float)this.Bounds.Size.Height);
    
            if(this.size != newSize)
            {
                Debug.WriteLine("Layout...");
                this.size = newSize;
                this.builder.Layout(SKRect.Create(SKPoint.Empty, ToPlatform(this.size)));
            }
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            this.OnViewInvalidated(this, EventArgs.Empty);
        }

        private static SKSize ToPlatform(SKSize point)
        {
            return new SKSize(point.Width * Density.Global, point.Height * Density.Global);
        }

        private static float FromPlatform(nfloat value)
        {
            return (float)value / Density.Global;
        }
    }
}
