
namespace SkiaSharp.Components
{
    public class Box : View
    {
        #region Fields

        private IBrush fill;

        private Stroke border;

        private Shadow shadow;

        private float cornerRadius;

        #endregion

        #region Properties

        public float CornerRadius
        {
            get => this.cornerRadius;
            set => this.SetAndInvalidate(ref this.cornerRadius, value);
        }

        public IBrush Fill
        {
            get => this.fill;
            set => this.SetAndInvalidate(ref this.fill, value);
        }

        public Stroke Border 
        {
            get => this.border;
            set => this.SetAndInvalidate(ref this.border, value);
        }

        public Shadow Shadow
        {
            get => this.shadow;
            set => this.SetAndInvalidate(ref this.shadow, value);
        }

        #endregion

        public override void Render(SKCanvas canvas)
        {
            base.Render(canvas);

            var path = new SKPath();

            if (this.CornerRadius > 0)
            {
                path.AddRoundedRect(this.AbsoluteFrame, this.CornerRadius, this.CornerRadius);
            }
            else
            {
                path.AddRect(this.AbsoluteFrame);
            }

            if (this.Shadow != null)
            {
                using (var paint = new SKPaint()
                {
                    ImageFilter = SKImageFilter.CreateDropShadow(this.Shadow.Offset.X, this.Shadow.Offset.Y, this.Shadow.Blur.X, this.Shadow.Blur.Y, this.Shadow.Color, SKDropShadowImageFilterShadowMode.DrawShadowOnly),
                })
                {
                    canvas.DrawPath(path, paint);
                }
            }

            if(this.Fill != null)
                this.Fill.Fill(canvas, path);

            if(this.Border != null)
                this.Border.Brush.Stroke (canvas, path, this.Border.Size, this.Border.Style, this.Border.Cap, this.Border.Join);
        }
    }
}
