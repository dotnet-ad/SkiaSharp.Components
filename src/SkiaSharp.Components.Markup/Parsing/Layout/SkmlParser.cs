using System.Xml.Linq;
using System.Collections.Generic;
using Facebook.Yoga;
using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace SkiaSharp.Components
{
    public class SkmlParser
    {
        public SkmlParser(Func<string,Task<Stream>> getContent = null)
        {
            this.getContent = getContent ?? GetFileContent;

            this.AddNode(new NodeParser("Node"));
            this.AddNode(new NodeParser("Row").WithMiddleware((n) => n.FlexDirection = YogaFlexDirection.Row));
            this.AddNode(new NodeParser("Column").WithMiddleware((n) => n.FlexDirection = YogaFlexDirection.Column));
            this.AddNode(new ViewNodeParser(typeof(Box)));
            this.AddNode(new ViewNodeParser(typeof(Label)));
            this.AddNode(new ViewNodeParser(typeof(Image)));
            this.AddNode(new ViewNodeParser(typeof(Path)));
        }

        public static Func<string, Task<Stream>> GetFileContent = (id) => Task.FromResult((Stream)File.OpenRead(id));

        private Func<string, Task<Stream>> getContent;

        private Dictionary<string, NodeParser> nodes = new Dictionary<string, NodeParser>();

        public NodeParser AddNode(NodeParser p) => nodes[p.Name] = p;

        private Layout layout;

        public async Task<Layout> ParseAsync(Layout layout)
        {
            this.layout = layout;

            using (var xmlstream = await getContent(layout.Path))
            using (var reader = new StreamReader(xmlstream, Encoding.UTF8))
            {
                var content = reader.ReadToEnd();

                // Trimming UTF8 special char
                string utf8Mark = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
                if (content.StartsWith(utf8Mark, StringComparison.Ordinal))
                {
                    content = content.Remove(0, utf8Mark.Length);
                }

                var xml = XDocument.Parse(content, LoadOptions.SetLineInfo);

                var name = xml.Root?.Attribute("Class")?.Value;

                // Loading all stylesheets
                var skssParser = new SkssParser();
                var folder = System.IO.Path.GetDirectoryName(this.layout.Path);
                var stylesheetsNames = xml.Root.Attribute("Stylesheets")?.Value?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries) ?? new string[] { };
                var stylesheetsTasks = await Task.WhenAll(stylesheetsNames.Select(x => System.IO.Path.Combine(folder, x)).Select(x => getContent(x)));
                var stylesheets = stylesheetsTasks.Select(stream =>
                {
                    using (stream)
                    {
                        return skssParser.Parse(stream);
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
                    Root = await ParseNodeAsync(xml.Root.Elements().First(), stylesheet),
                };

                return new Layout()
                {
                    Path = layout.Path,
                    Class = name,
                    View = view,
                };
            }
        }

        private async Task<Flex.Node> ParseNodeAsync(XElement element, Stylesheet stylesheet)
        {
            if(element.Name == "Include")
            {
                var path = element.Attribute("Source")?.Value;
                var folder = System.IO.Path.GetDirectoryName(this.layout.Path);
                var includePath = System.IO.Path.Combine(folder, path);

                using(var stream = await getContent(includePath))
                {
                    var includeLayout = new Layout
                    {
                        Path = includePath,
                    };

                    var includeParser = new SkmlParser(getContent);
                    var included = await includeParser.ParseAsync(includeLayout);
                    return included.View.Root;
                }
            }

            NodeParser node;

            if(!this.nodes.TryGetValue(element.Name.ToString(), out node))
            {
                node = new ViewNodeParser(Type.GetType(element.Name.ToString())); 
            }

            var result = node.ParseNode(element, stylesheet);

            foreach (var child in element.Elements())
            {
                var childNode = await ParseNodeAsync(child, stylesheet);
                result.AddChild(childNode);
            }

            return result;
        }
    }
}
