using System.Collections.Generic;
using System.Xml.Linq;

namespace SkiaSharp.Components
{
    public class Layout
    {
        public string Class { get; set; }

        public XDocument Content { get; set; }

        public List<Stylesheet> Stylesheets { get; set; } = new List<Stylesheet>();

        public Flex View { get; set; }
    }
}
