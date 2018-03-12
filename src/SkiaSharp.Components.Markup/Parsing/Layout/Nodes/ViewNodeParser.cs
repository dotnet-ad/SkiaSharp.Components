using System;
using System.Linq;
using System.Text;

namespace SkiaSharp.Components
{
    public class ViewNodeParser : NodeParser 
    {
        private Type viewType;

        public ViewNodeParser(Type t) : base(t.Name)
        {
            this.viewType = t;
            var properties = t.GetProperties();

            foreach (var property in properties)
            {
                var propertyName = ToSeparatorCase(property.Name);
              
                this.WithStyle(propertyName, property.PropertyType, (n, v) =>
                {
                    property.SetValue(n.Data, v);
                });
            }
        }

        public static string ToSeparatorCase(string value)
        {
            var b = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                var c = value.ElementAt(i);
                if (char.IsUpper(c))
                {
                    if (i > 0)
                    {
                        b.Append("-");
                    }

                    b.Append($"{c}".ToLowerInvariant());
                }
                else
                {
                    b.Append(c);
                }
            }

            return b.ToString();
        }

        public override View CreateView()
        {
            return (View)Activator.CreateInstance(viewType);
        }
    }
}
