using System;
using System.Diagnostics;
using System.Net.Http;

namespace SkiaSharp.Components
{
    public class Image : View
    {
        #region Fields

        private Aspect aspect;

        private string source;

        private SKImage image;

        #endregion

        public Aspect Aspect
        {
            get => this.aspect;
            set => this.SetAndInvalidate(ref this.aspect, value);
        }

        public string Source
        {
            get => this.source;
            set => this.UpdateSource(value);
        }

        private static HttpClient client = new HttpClient();

        private async void UpdateSource(string source)
        {
            if (this.source != source)
            {
                this.source = source;

                if (source == null)
                {
                    this.image = null;
                }
                else if (source.StartsWith("http://") || source.StartsWith("https://"))
                {
                    try
                    {
                        using (var stream = await client.GetStreamAsync(source))
                        {
                            var bitmap = SKBitmap.Decode(stream);
                            this.SetAndInvalidate(ref this.image, SKImage.FromBitmap(bitmap));
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Failed to download image: {ex}");
                    }
                }
            }
        }

        protected override void Render(SKCanvas canvas, SKRect frame)
        {
            base.Render(canvas, frame);

            if (image != null)
            {
                SKRect sourceRect = SKRect.Create(0, 0, this.image.Width, this.image.Height);
                SKRect destRect = frame;

                var sourceRatio = sourceRect.Width / sourceRect.Height;
                var destRatio = destRect.Width / destRect.Height;

                switch (this.Aspect)
                {
                    case Aspect.AspectFit:
                        if (destRect.Width > destRect.Height)
                        {
                            var h = frame.Height;
                            var w = h * sourceRatio;
                            var x = frame.MidX - w / 2;
                            destRect = SKRect.Create(x, frame.Top, w, h);
                        }
                        else
                        {
                            var w = frame.Width;
                            var h = w / sourceRatio;
                            var y = frame.MidY - h / 2;
                            destRect = SKRect.Create(frame.Left, y, w, h);
                        }
                        break;
                    case Aspect.AspectFill:
                        if (sourceRect.Width > sourceRect.Height)
                        {
                            var h = sourceRect.Height;
                            var w = h * destRatio;
                            var x = sourceRect.MidX - w / 2;
                            sourceRect = SKRect.Create(x, sourceRect.Top, w, h);
                        }
                        else
                        {
                            var w = sourceRect.Width;
                            var h = w / destRatio;
                            var y = sourceRect.MidY - h / 2;
                            sourceRect = SKRect.Create(sourceRect.Left, y, w, h);
                        }
                        break;
                    default:
                        sourceRect = SKRect.Create(0, 0, this.image.Width, this.image.Height);
                        break;
                }
                canvas.DrawImage(this.image, sourceRect, destRect);
            }
        }
    }
}
