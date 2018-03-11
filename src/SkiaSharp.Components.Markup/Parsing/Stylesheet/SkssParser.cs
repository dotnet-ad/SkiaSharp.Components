using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace SkiaSharp.Components
{
    public class SkssParser
    {
        private static Regex classRegex = new Regex(@"\.([a-zA-Z-_0-9]+)\s*\{([^\{]*)\}");

        public Stylesheet Parse(Stream stream)
        {
            var result = new Stylesheet();

            using(var reader = new StreamReader(stream, Encoding.UTF8, true, 2048, true))
            {
                var content = reader.ReadToEnd();

                var matches = classRegex.Matches(content);

                foreach (Match match in matches)
                {
                    var name = match.Groups[1].Value;
                    var body = match.Groups[2].Value;
                    var properties = body.Split(';')
                                         .Select(x => x.Trim().Split(':'))
                                         .Where(x => x.Length == 2)
                                         .ToDictionary(x => x[0], x => x[1]);
                    
                    result.AddClass(name, properties);
                }
            }

            return result;
        }
    }
}
