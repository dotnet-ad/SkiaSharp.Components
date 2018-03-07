using System;
using System.Collections.Generic;
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

        private IEnumerable<Span> spans;

        private float? lineHeight;

        private Span style = new Span()
        {
            TextSize = DefaultTextSize,
        };

        private Alignment verticalAlignment;

        #endregion

        #region Properties

        public Alignment VerticalAlignment 
        {
            get => this.verticalAlignment;
            set => this.SetAndInvalidate(ref this.verticalAlignment, value);
        }

        public IEnumerable<Span> Spans 
        {
            get => this.spans;
            set => this.SetAndInvalidate(ref this.spans, value);
        }

        public IBrush ForegroundBrush
        {
            get => this.style.ForegroundBrush;
            set => this.SetAndInvalidate(() => this.ForegroundBrush, (v) => this.style.ForegroundBrush = v, value);
        }

        public SKTypeface Typeface
        {
            get => this.style.Typeface;
            set => this.SetAndInvalidate(() => this.Typeface, (v) => this.style.Typeface = v, value);
        }

        public float TextSize
        {
            get => this.style.TextSize;
            set => this.SetAndInvalidate(() => this.TextSize, (v) => this.style.TextSize = v, value);
        }

        public float LineHeight
        {
            get => this.lineHeight ?? this.TextSize * 1.2f;
            set => this.SetAndInvalidate(ref this.lineHeight, value);
        }

        public string Text
        {
            get => string.Join("", this.Spans.Select(x => x.Text) ?? new string[0]);
            set => this.Spans = new[]
            {
                new Span(this.style)
                {
                    Text = value,
                }
            };
        }

        #endregion

        public override void Render(SKCanvas canvas)
        {
            var absolute = this.AbsoluteFrame;

            var splitSpans = SplitLines(this.Spans, this.AbsoluteFrame, this.LineHeight, out SKSize totalSize);

            var offset = SKPoint.Empty;

            if (this.VerticalAlignment == Alignment.Center)
            {
                offset.Y = absolute.Height / 2 - totalSize.Height / 2;
            }
            else if (this.VerticalAlignment == Alignment.End)
            {
                offset.Y = absolute.Height - totalSize.Height;
            }

            foreach (var span in splitSpans)
            {
                var area = SKRect.Create(offset.X + absolute.Left + span.LayoutFrame.Left - span.Bounds.Left, offset.Y + absolute.Top + span.LayoutFrame.Top, span.LayoutFrame.Width, span.LayoutFrame.Height);
                span.ForegroundBrush.Text(canvas, span.Text, area, span.Typeface, span.TextSize, span.Decorations);
            }
        }

        private static SKSize Measure(Label view, SKRect area)
        {
            var spans = SplitLines(view.Spans, area, view.LineHeight, out SKSize size);
            return size;
        }

        private static IEnumerable<Span> Split(IEnumerable<Span> spans, char c)
        {
            return spans.SelectMany(r =>
            {
                if (r.Text == null)
                    return new Span[0];

                var returns = r.Text.Split(new[] { c }, StringSplitOptions.None);
                return returns.SelectMany((s, i) =>
                {
                    var result = new List<Span>();
                    if (i > 0)
                    {
                        result.Add(new Span(r)
                        {
                            Text = c.ToString(),
                        });
                    }
                    if (!string.IsNullOrEmpty(s))
                    {
                        result.Add(new Span(r)
                        {
                            Text = s,
                        });
                    }
                    return result;
                });
            });
        }

        private static float UpdateLineHeight(int line, List<Span> spans, float lineHeight)
        {
            if (line == 0)
            {
                var height = spans.Max(s => -s.Bounds.Top);
                foreach (var span in spans)
                {
                    var f = span.LayoutFrame;
                    span.LayoutFrame = SKRect.Create(f.Left, f.Top, f.Width, height);
                }
                return height;
            }

            return lineHeight;
        }

        private static Span[] SplitLines(IEnumerable<Span> text, SKRect frame, float lineHeight, out SKSize size)
        {
            if (text == null)
            {
                size = SKSize.Empty;
                return new Span[0];
            }

            // splittingLines
            var spans = Split(text, '\n');

            // Splitting words
            spans = Split(spans, ' ').ToList();

            var updatedSpans = new List<Span>();

            float y = 0, x = 0;
            SKRect bounds = SKRect.Empty;
            int line = 0;

            foreach (var span in spans)
            {
                using (var paint = new SKPaint
                {
                    Style = SKPaintStyle.Fill,
                    TextAlign = SKTextAlign.Left,
                    Typeface = span.Typeface,
                    FakeBoldText = span.Decorations.HasFlag(TextDecoration.Bold),
                    TextSize = span.TextSize,
                })
                {
                    var previousLine = line;

                    if (span.Text == "\n")
                    {
                        var newLineHeight = UpdateLineHeight(line, updatedSpans, lineHeight);
                        line++;
                        x = 0;
                        y += newLineHeight;
                    }
                    else if (span.Text == " ")
                    {
                        x += paint.MeasureText(span.Text);
                    }
                    else if (span.Text != null)
                    {
                        if (span.Text.Length > 0)
                        {
                            paint.MeasureText(span.Text, ref bounds);

                            var shouldReturn = x > 0 && x + bounds.Width - bounds.Left > frame.Width + 1;

                            if (shouldReturn)
                            {
                                var newLineHeight = UpdateLineHeight(line, updatedSpans, lineHeight);
                                line++;
                                x = 0;
                                y += newLineHeight;
                            }

                            updatedSpans.Add(new Span()
                            {
                                Text = span.Text,
                                ForegroundBrush = span.ForegroundBrush,
                                TextSize = span.TextSize,
                                Line = line,
                                Typeface = span.Typeface,
                                Bounds = bounds,
                                LayoutFrame = SKRect.Create(x, y, bounds.Width - bounds.Left, lineHeight),
                            });

                            x += bounds.Width;
                        }
                    }
                }
            }

            if (line == 0)
            {
                UpdateLineHeight(line, updatedSpans, lineHeight);
            }

            var result = updatedSpans.ToArray();

            // Total size
            var h = result.Length > 0 ? result.Max(s => s.LayoutFrame.Bottom) - result.Min(s => s.LayoutFrame.Top) : 0;
            var w = result.Length > 0 ? result.Max(s => s.LayoutFrame.Right) - result.Min(s => s.LayoutFrame.Left) : 0;
            size = new SKSize(w, h);

            return result;
        }
    }
}
