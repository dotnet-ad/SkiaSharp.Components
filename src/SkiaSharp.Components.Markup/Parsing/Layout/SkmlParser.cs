using System.Xml.Linq;
using System.Collections.Generic;
using Facebook.Yoga;
using System;
using System.Linq;

namespace SkiaSharp.Components
{
    public class SkmlParser
    {
        public SkmlParser()
        {
            this.AddNode(new NodeParser("Node"));
            this.AddNode(new NodeParser("Row").WithMiddleware((n) => n.FlexDirection = YogaFlexDirection.Row));
            this.AddNode(new NodeParser("Column").WithMiddleware((n) => n.FlexDirection = YogaFlexDirection.Column));
            this.AddNode(new ViewNodeParser(typeof(Box)));
            this.AddNode(new ViewNodeParser(typeof(Label)));
            this.AddNode(new ViewNodeParser(typeof(Image)));
            this.AddNode(new ViewNodeParser(typeof(Path)));
        }

        private Dictionary<string, NodeParser> nodes = new Dictionary<string, NodeParser>();

        public NodeParser AddNode(NodeParser p) => nodes[p.Name] = p;

        public Layout Parse(Layout layout)
        {
            var name = layout.Content.Root?.Attribute("Class")?.Value;

            var stylesheet = new Stylesheet();

            foreach (var s in layout.Stylesheets)
            {
                stylesheet = stylesheet.Merge(s);
            }

            var view = new Flex
            {
                Root = ParseNode(layout.Content.Root.Elements().First(), stylesheet),
            };

            return new Layout()
            {
                Stylesheets = layout.Stylesheets,
                Class = name,
                View = view,
            };
        }

        private Flex.Node ParseNode(XElement element, Stylesheet stylesheet)
        {
            NodeParser node;

            if(!this.nodes.TryGetValue(element.Name.ToString(), out node))
            {
                node = new ViewNodeParser(Type.GetType(element.Name.ToString())); 
            }

            var result = node.ParseNode(element, stylesheet);

            foreach (var child in element.Elements())
            {
                var childNode = ParseNode(child, stylesheet);
                result.AddChild(childNode);
            }

            return result;
        }
    }
}
