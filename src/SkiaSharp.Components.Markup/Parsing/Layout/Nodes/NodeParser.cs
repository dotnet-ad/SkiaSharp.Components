using System.Xml.Linq;
using System.Collections.Generic;
using System;
using System.Linq;
using Facebook.Yoga;

namespace SkiaSharp.Components
{
    public class NodeParser
    {
        public NodeParser(string name)
        {
            this.Name = name;

            //TODO add all flex properties
            this.WithStyle<float>("flex", (n,v) => n.FlexValue = v);
            this.WithStyle<YogaAlign>("align-items", (n, v) => n.AlignItems = v);
            this.WithStyle<YogaAlign>("align-self", (n, v) => n.AlignSelf = v);
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
            return this.WithStyle(name, typeof(T), (n,t) => setter(n, (T)t));
        }

        public NodeParser WithStyle(string name, Type type, Action<Flex.Node, object> setter)
        {
            this.styleProperties[name] = new PropertyParser(name, type, setter);
            return this;
        }

        public NodeParser WithMiddleware(Action<Flex.Node> middleware)
        {
            this.Middlewares.Add(middleware);
            return this;
        }

        public Flex.Node ParseNode(XElement element, Stylesheet stylesheet)
        {
            var view = CreateView();

            var result = view == null ? new Flex.Node() : new Flex.Node(view);

            if(view != null)
                view.Name = element.Attribute("Name")?.Value;

            var stylesProperties = new Dictionary<string, string>();

            var classes = element.Attribute("Class");
            if (classes != null)
            {
                var properties = stylesheet.GetProperties(classes.Value);

                foreach (var p in properties)
                {
                    stylesProperties[p.Key] = p.Value;
                }
            }

            var style = element.Attribute("Style");
            if (style != null)
            {
                var properties = style.Value.Split(';')
                                     .Select(x => x.Trim().Split(':'))
                                     .Where(x => x.Length == 2)
                                     .ToDictionary(x => x[0], x => x[1]);

                foreach (var p in properties)
                {
                    stylesProperties[p.Key] = p.Value;
                }
            }

            ParseStyles(result, stylesProperties);

            foreach (var middleware in Middlewares)
            {
                middleware(result);
            }

            return result;
        }

        private void ParseStyles(Flex.Node node, IDictionary<string,string> style)
        {
            foreach (var property in style)
            {
                if (this.styleProperties.TryGetValue(property.Key, out PropertyParser setter))
                {
                    setter.Set(node, property.Value);
                }
            }
        }

        public virtual View CreateView() => null;
    }
}
