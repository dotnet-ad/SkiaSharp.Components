using System.IO;
using SkiaSharp.Components.Markup;
using Facebook.Yoga;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Linq;
using System.Collections;
using System.Diagnostics;

namespace SkiaSharp.Components
{
    public class CsharpGenerator : Generator
    {
        public void Generate(Layout layout, Stream output)
        {
            using(var writer = new StreamWriter(output))
            {
                writer.Write(Generate(layout));
            }
        }

        public string Generate(Layout layout)
        {
            var classSplits = layout.Class?.Trim().Split('.');
            var className = classSplits?.Last() ?? "Unknown";
            var classNamespace = string.Join(".", classSplits?.Take(classSplits.Length - 1) ?? new[] { "Unknown" });

            this.Reset();

            this.AppendLine($"namespace {classNamespace}");
            this.Body(() =>
            {
                // Usings
                this.AppendLine($"using System;");
                this.AppendLine($"using SkiaSharp;");
                this.AppendLine($"using SkiaSharp.Components;");


                // Class
                this.AppendLine($"public partial class {className} : Flex");
                this.Body(() =>
                {
                    var members = new List<string>();

                    this.AppendLine($"private void Initialize()");
                    this.Body(() =>
                    {
                        var root = this.Generate(layout.View.Root, members);
                        this.AppendLine($"this.Root = {root};");
                    });

                    members.OrderBy(x => x);
                    foreach (var member in members)
                    {
                        this.AppendLine(member);
                    }
                });
            });

            return builder.ToString();
        }

        private static Flex.Node DefaultNode = new Flex.Node();
        private static PropertyInfo[] NodeProperties = typeof(Flex.Node).GetRuntimeProperties()
                                                                        .Where(x => x.CanWrite && x.CanRead)
                                                                        .Where(x => x.Name != nameof(DefaultNode.Data))
                                                                        .Where(x => x.Name != nameof(DefaultNode.View))
                                                                        .Where(x => x.Name != nameof(DefaultNode.Parent))
                                                                        .ToArray();

        private static bool AreValueEquals(object a, object b)
        {
            return (a == b) ||
                   (a != null && a.Equals(b)) ||
                   (a is YogaValue va && float.IsNaN(va.Value) && b is YogaValue vb && float.IsNaN(vb.Value));
        }

        private string Generate(YogaNode node, List<string> members)
        {
            var nodeName = $"node_{NewId()}";
            this.AppendLine($"var {nodeName} = new Flex.Node();");

            // Generating all YogaNode properties
            foreach (var property in NodeProperties)
            {
                var defaultValue = property.GetValue(DefaultNode);
                var currentValue = property.GetValue(node);

                if (!AreValueEquals(currentValue,defaultValue))
                {
                    Debug.WriteLine($"{nodeName}.{property.Name} :> '{defaultValue}' != '{currentValue}'");
                    this.AppendLine($"{nodeName}.{property.Name} = {GenerateValue(currentValue)};");
                }
                else
                {
                    Debug.WriteLine($"{nodeName}.{property.Name} :> '{defaultValue}' == '{currentValue}'");
                }
            }

            if(node.Data is View view)
            {
                string viewName = null;
                var viewType = view.GetType().FullName;
                if(view.Name != null)
                {
                    viewName = view.Name;
                    members.Add($"public {viewType} {viewName} {{ get; private set; }}");
                }
                else
                {
                    viewName = "view_" + NewId();
                    members.Add($"private {viewType} {viewName};");
                }

                this.AppendLine($"this.{viewName} = new {viewType}();");

                // Generating all view properties
                var defaultView = Activator.CreateInstance(view.GetType()) as View;
                var viewProperties = view.GetType().GetRuntimeProperties()
                                                   .Where(x => x.CanWrite && x.CanRead)
                                                   .Where(x => x.Name != nameof(defaultView.Parent))
                                                   .Where(x => x.Name != nameof(defaultView.LayoutFrame))
                                                   .ToArray();
                
                foreach (var property in viewProperties)
                {
                    var defaultValue = property.GetValue(defaultView);
                    var currentValue = property.GetValue(view);

                    if(currentValue != defaultValue)
                    {
                        Debug.WriteLine($"{viewName}.{property.Name} :> '{defaultValue}' != '{currentValue}'");
                        this.AppendLine($"this.{viewName}.{property.Name} = {GenerateValue(currentValue)};");
                    }
                    else
                    {
                        Debug.WriteLine($"{viewName}.{property.Name} :> '{defaultValue}' == '{currentValue}'");
                    }
                }

                this.AppendLine($"{nodeName}.View = this.{viewName};");
            }

            foreach (var child in node)
            {
                this.AppendLine("");
                var childName = Generate(child, members);
                this.AppendLine($"{nodeName}.AddChild({childName});");
            }

            return nodeName;
        }

        private string GenerateValue(object value)
        {
            switch(value)
            {
                //TODO Tuple<T,T2>
                case Object o when o.GetType().IsArray:
                    var enumerable = (o as IEnumerable);
                    var allItems = enumerable.Cast<object>().Select(x => GenerateValue(x));
                    var items = string.Join(", ", allItems);
                    return $"new {o.GetType().GetElementType().FullName} [] {{ {items} }}";

                case String s:
                    return $"\"{s}\"";

                case float f:
                    return $"{f}f";

                case SKColor c:
                    return $"new SKColor({c.Red},{c.Green},{c.Blue},{c.Alpha})";

                case SKPoint p:
                    return $"new SKPoint({p.X}, {p.Y})";

                case YogaValue v:
                    return v.Value.ToString();

                case SKRect r:
                    return $"SKRect.Create({r.Left}, {r.Top}, {r.Width}, {r.Height})";

                case Stroke s:
                    return $"new Stroke({GenerateValue(s.Size)}, {GenerateValue(s.Brush)}, {GenerateValue(s.Style)})";

                case Shadow s:
                    return $"new Shadow({GenerateValue(s.Offset)}, {GenerateValue(s.Blur)}, {GenerateValue(s.Color)})";

                case ColorBrush c:
                    return $"new ColorBrush({GenerateValue(c.Color)})";

                case GradientBrush c:
                    return $"new GradientBrush({GenerateValue(c.Start)},{GenerateValue(c.End)},{GenerateValue(c.Colors)})";

                case Object e when e.GetType().IsEnum:
                    return $"{e.GetType().FullName}.{e.ToString()}";

                default:
                    return value.ToString();

            }
        }
    }
}
