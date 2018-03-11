using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace SkiaSharp.Components.Samples
{
    public class MarkupSample
    { 
        private Stream Load(string name)
        {
            var names = this.GetType().Assembly.GetManifestResourceNames();
            name = names.FirstOrDefault(x => x.EndsWith("." + name));
            return this.GetType().Assembly.GetManifestResourceStream(name);
        }

        private Stylesheet Stylesheet(string name)
        {
            using (var stream = this.Load("Sample.skss"))
            {
                var parser = new SkssParser();
                return parser.Parse(stream);
            }
        }

        private Flex Layout(string name, Stylesheet s)
        {
            using (var stream = this.Load(name))
            {
                var xml = XDocument.Load(stream);
                var parser = new SkmlParser();
                return parser.Parse(xml,s);
            }
        }

        public View Build()
        {
            var stylesheet = Stylesheet("Sample.skss");
            var result = Layout("Sample.skml", stylesheet);

            var description = result.Root.Find<Label>("description");

            description.Text = "Hello world!";

            return result;
        }
    }
}
