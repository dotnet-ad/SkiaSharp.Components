namespace SkiaSharp.Components
{
    public class Path : View
    {
        public Path()
        {
            this.ClipBounds = false;
        }


        #region Constants

        public static readonly IBrush DefaultForegroundBrush = new ColorBrush(SKColors.Black);

        #endregion

        #region Fields

        private SKPath source;

        private SKRect? viewbox;

        private SKStrokeCap strokeCap = SKStrokeCap.Round;

        private float strokeSize;

        private IBrush foregroundBrush = DefaultForegroundBrush;

        private SKColor strokeColor = SKColors.Black;

        private SKColor fillColor = SKColors.Transparent;

        #endregion

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

        public IBrush ForegroundBrush
        {
            get => this.foregroundBrush;
            set => this.SetAndInvalidate(ref this.foregroundBrush, value);
        }

        public SKStrokeCap StrokeCap
        {
            get => this.strokeCap;
            set => this.SetAndInvalidate(ref this.strokeCap, value);
        }

        public SKColor StrokeColor
        {
            get => this.strokeColor;
            set => this.SetAndInvalidate(ref this.strokeColor, value);
        }

        public SKColor FillColor
        {
            get => this.fillColor;
            set => this.SetAndInvalidate(ref this.fillColor, value);
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

            var viewbox = this.viewbox ?? Source.Bounds;

            var sx = frame.Width / viewbox.Width;
            var sy = frame.Height / viewbox.Height;

            var matrix = SKMatrix.MakeScale(sx, sy);
            matrix.TransX = frame.Left - viewbox.Left * sx;
            matrix.TransY = frame.Top - viewbox.Top * sy;
            var path = new SKPath(this.Source);
            path.Transform(matrix);

            if (this.FillColor.Alpha > 0)
            {
                using (var paint = new SKPaint
                {
                    IsAntialias = true,
                    Style = SKPaintStyle.Fill,
                })
                using(var brush = this.ForegroundBrush.Apply(canvas, paint, frame))
                {
                    canvas.DrawPath(path, paint);
                }
            }

            if(this.StrokeSize > 0)
            {
                using (var paint = new SKPaint
                {
                    IsAntialias = true,
                    Style = SKPaintStyle.Stroke,
                    StrokeWidth = this.StrokeSize,
                    StrokeCap = this.StrokeCap
                })
                using (var brush = this.ForegroundBrush.Apply(canvas, paint, frame))
                {
                    canvas.DrawPath(path, paint);
                }
            }

        }
    }
}
