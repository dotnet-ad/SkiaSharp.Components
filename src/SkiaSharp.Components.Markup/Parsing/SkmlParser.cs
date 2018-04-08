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
            this.AddNode(new ImageParser());
            this.AddNode(new ImageParser());
        }

        private Dictionary<string, NodeParser> nodes = new Dictionary<string, NodeParser>();

        public NodeParser AddNode(NodeParser p) => nodes[p.Name] = p;

        public Flex Parse(XDocument document)
        {
            return new Flex
            {
                Root = ParseNode(document.Root),
            };
        }

        private Flex.Node ParseNode(XElement element)
        {
            var node = this.nodes[element.Name.ToString()];
            var result = node.ParseNode(element);

            foreach (var child in element.Elements())
            {
                var childNode = ParseNode(child);
                result.AddChild(childNode);
            }

            return result;
        }
    }
}
