using System;
using System.Linq;
using System.Reflection;

namespace SkiaSharp.Components
{
    public class ValueParser
    {
        public T Parse<T>(string value)
        {
            return (T)this.Parse(typeof(T), value);
        }

        public object Parse(Type type, string value)
        {
            if (type == typeof(string))
                return value;

            if (type == typeof(int))
                return int.Parse(value);

            if (type == typeof(float))
                return float.Parse(value);

            if (type == typeof(Margin))
                return Margin.Parse(value);

            if (type == typeof(IBrush))
            {
                if (value.StartsWith("#", StringComparison.Ordinal))
                    return new ColorBrush(this.Parse<SKColor>(value));
            }

            if (type == typeof(SKColor))
            {
                return SKColor.Parse(value);
            }

            if (type == typeof(SKPoint))
            {
                var values = value.Split(',')
                                  .Select(v => v.Trim())
                                  .ToArray();

                var x = this.Parse<float>(values.ElementAtOrDefault(0) ?? "0");
                var y = this.Parse<float>(values.ElementAtOrDefault(1) ?? "0");
                return new SKPoint(x,y);
            }

            if (type == typeof(SKSize))
            {
                var point = this.Parse<SKPoint>(value);
                return new SKSize(point.X, point.Y);
            }

            if (type == typeof(SKRect))
            {
                var values = value.Split(',')
                                  .Select(v => v.Trim())
                                  .ToArray();

                var x = this.Parse<float>(values.ElementAtOrDefault(0) ?? "0");
                var y = this.Parse<float>(values.ElementAtOrDefault(1) ?? "0");
                return new SKPoint(x, y);
            }

            if (type == typeof(Stroke))
            {
                var values = value.Split(',')
                                  .Select(x => x.Trim())
                                  .ToArray();
                
                return new Stroke
                {
                    Size = this.Parse<float>(values.ElementAtOrDefault(0) ?? "0"),
                    Brush = this.Parse<IBrush>(values.ElementAtOrDefault(1) ?? "#FFFFFFFF"),
                    Style = this.Parse<StrokeStyle>(values.ElementAtOrDefault(2) ?? "Line"),
                };
            }

            if (type == typeof(Shadow))
            {
                var values = value.Split(',')
                                  .Select(v => v.Trim())
                                  .ToArray();

                var x = this.Parse<float>(values.ElementAtOrDefault(0) ?? "0");
                var y = this.Parse<float>(values.ElementAtOrDefault(1) ?? "0");
                var bx = this.Parse<float>(values.ElementAtOrDefault(2) ?? "0");
                var by = this.Parse<float>(values.ElementAtOrDefault(3) ?? "0");
                var color = this.Parse<SKColor>(values.ElementAtOrDefault(4) ?? "#33000000");

                return new Shadow
                {
                    Offset = new SKPoint(x,y),
                    Blur = new SKPoint(bx,by),
                    Color = color,
                };
            }


            if (type.GetTypeInfo().IsEnum)
            {
                return Enum.Parse(type, value);
            }

            throw new InvalidOperationException($"Failed to parse style value '{value}'");
        }
    }
}
