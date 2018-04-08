namespace SkiaSharp.Components
{
    public class Path : View
    {
        #region Properties

        public SKRect? ViewBox
        {
            get => this.viewbox;
            set => this.SetAndInvalidate(ref this.viewbox, value);
        }

        public SKPath Source
        {
            get => this.source;
            set => this.SetAndInvalidate(ref this.source, value);
        }

        public IBrush Fill
        {
            get => this.fill;
            set => this.SetAndInvalidate(ref this.fill, value);
        }

        public Stroke Stroke
        {
            get => this.stroke;
            set => this.SetAndInvalidate(ref this.stroke, value);
        }

        #endregion

        #region Fields

        private SKPath source;

        private SKRect? viewbox;

        private IBrush fill;

        private Stroke stroke;

        #endregion

        public override void Render(SKCanvas canvas)
        {
            base.Render(canvas);

            var frame = this.AbsoluteFrame;

            var vb = this.ViewBox == SKRect.Empty || this.ViewBox == null ? this.Source.Bounds : this.ViewBox.Value;

            var sx = frame.Width / vb.Width;
            var sy = frame.Height / vb.Height;

            var matrix = SKMatrix.MakeScale(sx, sy);
            matrix.TransX = frame.Left - vb.Left * sx;
            matrix.TransY = frame.Top - vb.Top * sy;
            var path = new SKPath(this.Source);
            path.Transform(matrix);

            if(this.Fill != null)
                this.Fill.Fill(canvas,path);

            if(this.Stroke != null)
                this.Stroke.Brush.Stroke(canvas, path, this.Stroke.Size, this.Stroke.Style, this.Stroke.Cap, this.Stroke.Join);
        }
    }
}
