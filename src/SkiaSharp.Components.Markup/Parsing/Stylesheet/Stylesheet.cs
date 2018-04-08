using System.Collections.Generic;
using System.Linq;

namespace SkiaSharp.Components
{
    public class Stylesheet
    {
        private Dictionary<string, IDictionary<string, string>> classes = new Dictionary<string, IDictionary<string, string>>();

        public Stylesheet Merge(Stylesheet other)
        {
            var result = new Stylesheet();

            foreach (var item in this.classes)
            {
                result.AddClass(item.Key, item.Value);
            }

            foreach (var item in other.classes)
            {
                result.AddClass(item.Key, item.Value);
            }

            return result;
        }

        public void AddClass(string name, IDictionary<string, string> properties)
        {
            IDictionary<string, string> allProperties;

            if(!classes.TryGetValue(name, out allProperties))
            {
                allProperties = new Dictionary<string, string>();
                classes[name] = allProperties;
            }

            foreach (var item in properties)
            {
                allProperties[item.Key] = item.Value;
            }
        }

        public IDictionary<string, string> GetProperties(string classes)
        {
            var allProperties = new Dictionary<string, string>();

            foreach (var c in classes.Split(' ').Select(x => x.Trim()).Where(x => x.Length > 0))
            {
                if(this.classes.TryGetValue(c, out IDictionary<string, string> properties))
                {
                    foreach (var item in properties)
                    {
                        allProperties[item.Key] = item.Value;
                    }
                }
            }

            return allProperties;
        }
            
    }
}
