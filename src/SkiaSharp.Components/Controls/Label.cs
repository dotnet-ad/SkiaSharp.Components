using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiaSharp.Components
{
    public class Label : View
    {
        #region Constants

        public static readonly IBrush DefaultForegroundBrush = new ColorBrush(SKColors.Black);

        public const float DefaultTextSize = 20;

        #endregion

        #region Fields

        private string text;

        private float textSize = DefaultTextSize;

        private float? lineHeight;

        private IBrush foregroundBrush = DefaultForegroundBrush;

        private SKTypeface typeface;

        #endregion

        public string Text
        {
            get => this.text;
            set => this.SetAndInvalidate(ref this.text, value);
        }

        public IBrush ForegroundBrush
        {
            get => this.foregroundBrush;
            set => this.SetAndInvalidate(ref this.foregroundBrush, value);
        }

        public SKTypeface Typeface
        {
            get => this.typeface;
            set => this.SetAndInvalidate(ref this.typeface, value);
        }

        public float TextSize
        {
            get => this.textSize;
            set => this.SetAndInvalidate(ref this.textSize, value);
        }

        public float LineHeight
        {
            get => this.lineHeight ?? this.TextSize * 1.2f;
            set => this.SetAndInvalidate(ref this.lineHeight, value);
        }

        private KeyValuePair<string, SKRect>[] SplitLines(SKSize area)
        {
            if(string.IsNullOrEmpty(this.text))
            {
                return new KeyValuePair<string, SKRect>[0];
            }

            using (var paint = new SKPaint
            {
                TextSize = this.textSize,
            })
            {
                var spaceWidth = paint.MeasureText(" ");

                var words = text.Split(new[] { " " }, StringSplitOptions.None);

                var newLines = new List<KeyValuePair<string, SKRect>>();

                var line = new StringBuilder();
                float width = 0;
                float height = 0;
                float y = 0;
                SKRect bounds = SKRect.Empty;
                foreach (var word in words)
                {
                    paint.MeasureText(word, ref bounds);
                    var wordWithSpaceWidth = bounds.Width + spaceWidth;
                    var wordWithSpace = word + " ";

                    if (width + bounds.Width > area.Width)
                    {
                        var newLineHeight = newLines.Count == 0 ? height : this.LineHeight;
                        newLines.Add(new KeyValuePair<string, SKRect>(line.ToString(), SKRect.Create(0, y, width, newLineHeight)));
                        y += newLineHeight;
                        line = new StringBuilder(wordWithSpace);
                        width = wordWithSpaceWidth;
                        height = bounds.Height;
                    }
                    else
                    {
                        line.Append(wordWithSpace);
                        width += wordWithSpaceWidth;
                        height = Math.Max(height, bounds.Height);
                    }
                }

                var lastLine = line.ToString();
                paint.MeasureText(lastLine, ref bounds);
                var lastLineHeight = newLines.Count == 0 ? bounds.Height : this.LineHeight;
                newLines.Add(new KeyValuePair<string, SKRect>(lastLine, SKRect.Create(0, y, bounds.Width, lastLineHeight)));

                return newLines.ToArray();
            }
        }

        public override SKSize Measure(SKSize available)
        {
            var lines = this.SplitLines(available);
            var lastLine = lines.Last();
            return new SKSize(available.Width, lastLine.Value.Top + lastLine.Value.Height);
        }

        protected override void Render(SKCanvas canvas, SKRect frame)
        {
            base.Render(canvas, frame);

            using (var paint = new SKPaint
            {
                IsAntialias = true,
                TextSize = this.textSize,
                Typeface = typeface,
            })
            using (var brush = this.ForegroundBrush.Apply(canvas, paint, frame))
            {
                var lines = this.SplitLines(frame.Size);
                for (int i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    canvas.DrawText(line.Key, frame.Left + line.Value.Left, frame.Top + line.Value.Bottom, paint);
                }
            }
        }
    }
}
