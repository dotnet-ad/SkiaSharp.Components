using System.Collections.Generic;
using System.Xml.Linq;

namespace SkiaSharp.Components
{
    public class Layout
    {
        public string Class { get; set; }

        public string Path { get; set; }

        public XDocument Content { get; set; }

        public Flex View { get; set; }
    }
}
