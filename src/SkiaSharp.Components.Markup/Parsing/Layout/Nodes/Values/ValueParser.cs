using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SkiaSharp.Components
{
    public class ValueParser
    {
        public T Parse<T>(string value)
        {
            return (T)this.Parse(typeof(T), value);
        }

        public static string ToCamelCase(string value)
        {
            var b = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                var c = value.ElementAt(i);
                if(i == 0)
                {
                    b.Append($"{c}".ToUpperInvariant());
                }
                else if (i == '-' && i < value.Length - 1)
                {
                    c = value.ElementAt(i+1);
                    b.Append($"{c}".ToUpperInvariant());
                    i++;
                }
                else
                {
                    b.Append(c);
                }
            }

            return b.ToString();
        }

        public object Parse(Type type, string value)
        {
            value = value.Trim();

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

                var size = this.Parse<float>(values.ElementAtOrDefault(0) ?? "0");
                var brush = this.Parse<IBrush>(values.ElementAtOrDefault(1) ?? "#FFFFFFFF");
                var style = this.Parse<StrokeStyle>(values.ElementAtOrDefault(2) ?? "Line");
                var cap = this.Parse<SKStrokeCap>(values.ElementAtOrDefault(3) ?? "Round");
                var join = this.Parse<SKStrokeJoin>(values.ElementAtOrDefault(4) ?? "Round");
                return new Stroke(size, brush, style, cap, join);
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

                return new Shadow(new SKPoint(x, y), new SKPoint(bx, by), color);
            }

            if (type == typeof(SKPath))
            {
                return SKPath.ParseSvgPathData(value);
            }


            if (type.GetTypeInfo().IsEnum)
            {
                return Enum.Parse(type, ToCamelCase(value));
            }

            throw new InvalidOperationException($"Failed to parse style value '{value}'");
        }
    }
}
