using System;

namespace SkiaSharp.Components
{
    public class PropertyParser : ValueParser
    {
        public PropertyParser(string name, Type type, Action<Flex.Node, object> setter)
        {
            this.Name = name;
            this.PropertyType = type;
            this.setter = setter;
        }

        public string Name { get; }

        public Type PropertyType { get; }

        private Action<Flex.Node, object> setter;

        public void Set(Flex.Node node, string value)
        {
            var v = Parse(this.PropertyType, value);
            setter(node,v);
        }
    }
}
