using System.Xml.Linq;
using System.Collections.Generic;
using Facebook.Yoga;
using System;
using System.Linq;
using System.IO;

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

        private Layout layout;

        public Layout Parse(Layout layout)
        {
            this.layout = layout;

            var name = layout.Content.Root?.Attribute("Class")?.Value;

            // Loading all stylesheets
            var skssParser = new SkssParser();
            var folder = System.IO.Path.GetDirectoryName(this.layout.Path);
            var stylesheetsNames = layout.Content.Root.Attribute("Stylesheets")?.Value?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries) ?? new string[] { };
            var stylesheets = stylesheetsNames.Select(x => System.IO.Path.Combine(folder, x))
                                              .Select(x =>
                                              {
                                                  using (var skssStream = File.OpenRead(x))
                                                  {
                                                      return skssParser.Parse(skssStream);
                                                  }
                                              }).ToArray();

            // Merging stylesheets
            var stylesheet = new Stylesheet();
            foreach (var s in stylesheets)
            {
                stylesheet = stylesheet.Merge(s);
            }

            var view = new Flex
            {
                Root = ParseNode(layout.Content.Root.Elements().First(), stylesheet),
            };

            return new Layout()
            {
                Class = name,
                View = view,
            };
        }

        private Flex.Node ParseNode(XElement element, Stylesheet stylesheet)
        {
            if(element.Name == "Include")
            {
                var path = element.Attribute("Source")?.Value;
                var folder = System.IO.Path.GetDirectoryName(this.layout.Path);
                var includePath = System.IO.Path.Combine(folder, path);
                var includeLayout = new Layout
                {
                    Path = includePath,
                    Content = XDocument.Load(includePath),
                };

                var includeParser = new SkmlParser();
                var included = includeParser.Parse(includeLayout);
                return included.View.Root;
            }

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
