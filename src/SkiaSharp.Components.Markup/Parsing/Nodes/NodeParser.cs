using System.Xml.Linq;
using System.Collections.Generic;
using System;
using System.Linq;

namespace SkiaSharp.Components
{
    public class NodeParser
    {
        public NodeParser(string name)
        {
            this.Name = name;

            //TODO add all flex properties
            this.WithStyle<float>("flex", (n,v) => n.Flex = v);
            this.WithStyle<float>("width", (n, v) => n.Width = v);
            this.WithStyle<float>("height", (n, v) => n.Height = v);
            this.WithStyle<Margin>("margin", (n, v) =>
            {
                n.MarginLeft = v.Left;
                n.MarginTop = v.Top;
                n.MarginRight = v.Right;
                n.MarginBottom = v.Bottom;
            });
            this.WithStyle<float>("margin-right", (n, v) => n.MarginRight = v);
            this.WithStyle<float>("margin-left", (n, v) => n.MarginLeft = v);
            this.WithStyle<float>("margin-top", (n, v) => n.MarginTop = v);
            this.WithStyle<float>("margin-bottom", (n, v) => n.MarginBottom = v);
            this.WithStyle<Margin>("padding", (n, v) =>
            {
                n.PaddingLeft = v.Left;
                n.PaddingTop = v.Top;
                n.PaddingRight = v.Right;
                n.PaddingBottom = v.Bottom;
            });
            this.WithStyle<float>("padding-right", (n, v) => n.PaddingRight = v);
            this.WithStyle<float>("padding-left", (n, v) => n.PaddingLeft = v);
            this.WithStyle<float>("padding-top", (n, v) => n.PaddingTop = v);
            this.WithStyle<float>("padding-bottom", (n, v) => n.PaddingBottom = v);
        }

        public List<Action<Flex.Node>> Middlewares { get; } = new List<Action<Flex.Node>>();

        private Dictionary<string, PropertyParser> styleProperties = new Dictionary<string, PropertyParser>();

        public string Name { get; }

        public NodeParser WithStyle<T>(string name, Action<Flex.Node,T> setter)
        {
            this.styleProperties[name] = new PropertyParser(name, typeof(T), (n,v) => setter(n,(T)v));
            return this;
        }

        public NodeParser WithMiddleware(Action<Flex.Node> middleware)
        {
            this.Middlewares.Add(middleware);
            return this;
        }

        public Flex.Node ParseNode(XElement element)
        {
            var view = CreateView();

            var result = view == null ? new Flex.Node() : new Flex.Node(view);

            if(view != null)
                view.Name = element.Attribute("Name")?.Value;

            var style = element.Attribute("Style");
            if (style != null)
            {
                ParseStyles(result, style.Value);
            }

            foreach (var middleware in Middlewares)
            {
                middleware(result);
            }

            return result;
        }

        private void ParseStyles(Flex.Node node, string style)
        {
            var styles = style.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());

            foreach (var property in styles)
            {
                var split = property.Split(':');
                if (split.Length > 1)
                {
                    var name = split[0];
                    var value = split[1];
                    if (this.styleProperties.TryGetValue(name, out PropertyParser setter))
                    {
                        setter.Set(node, value);
                    }
                }
            }
        }

        public virtual View CreateView() => null;
    }
}
