using System.Linq;
using System.Xml.Linq;

namespace SkiaSharp.Components.Samples
{
    public class MarkupSample
    { 
        public View Build()
        {
            var names = this.GetType().Assembly.GetManifestResourceNames();
            var name = names.FirstOrDefault(x => x.EndsWith("Sample.skml"));
            using(var stream = this.GetType().Assembly.GetManifestResourceStream(name))
            {
                var xml = XDocument.Load(stream);
                var parser = new SkmlParser();
                return parser.Parse(xml);
            }  
        }
    }
}
