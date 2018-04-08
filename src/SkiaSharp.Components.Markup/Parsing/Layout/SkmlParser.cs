using System.Xml.Linq;
using System.Collections.Generic;

namespace SkiaSharp.Components
{
    public class SkmlParser
    {
        public SkmlParser()
        {
            this.AddNode(new NodeParser("Node"));
            this.AddNode(new ColumnParser());
            this.AddNode(new RowParser());
            this.AddNode(new BoxParser());
            this.AddNode(new LabelParser());
            this.AddNode(new ImageParser());
            this.AddNode(new PathParser());
        }

        private Dictionary<string, NodeParser> nodes = new Dictionary<string, NodeParser>();

        public NodeParser AddNode(NodeParser p) => nodes[p.Name] = p;

        public Flex Parse(XDocument document, Stylesheet stylesheet)
        {
            return new Flex
            {
                Root = ParseNode(document.Root, stylesheet),
            };
        }

        private Flex.Node ParseNode(XElement element, Stylesheet stylesheet)
        {
            var node = this.nodes[element.Name.ToString()];
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
