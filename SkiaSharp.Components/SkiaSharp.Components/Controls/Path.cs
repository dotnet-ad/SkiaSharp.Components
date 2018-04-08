namespace SkiaSharp.Components
{
    public class Path : View
    {
        public Path()
        {
            this.ClipBounds = false;
        }

        #region Fields

        private SKPath source;

        private float strokeSize;

        private SKColor foregroundColor = SKColors.Black;

        #endregion

        public SKPath Source
        {
            get => this.source;
            set => this.SetAndInvalidate(ref this.source, value);
        }

        public SKColor ForegroundColor
        {
            get => this.foregroundColor;
            set => this.SetAndInvalidate(ref this.foregroundColor, value);
        }

        public float StrokeSize
        {
            get => this.strokeSize;
            set => this.SetAndInvalidate(ref this.strokeSize, value);
        }

        // TODO aspect

        protected override void Render(SKCanvas canvas, SKRect frame)
        {
            base.Render(canvas, frame);

            using(var paint = new SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Stroke,
                Color = this.ForegroundColor,
                StrokeWidth = this.StrokeSize,
            })
            {
                var sx = frame.Width / Source.Bounds.Width;
                var sy = frame.Height / Source.Bounds.Height;

                var matrix = SKMatrix.MakeScale(sx,sy);
                matrix.TransX = frame.Left;
                matrix.TransY = frame.Top;
                var path = new SKPath(this.Source);
                path.Transform(matrix);

                canvas.DrawPath(path, paint);

            }

        }
    }
}
