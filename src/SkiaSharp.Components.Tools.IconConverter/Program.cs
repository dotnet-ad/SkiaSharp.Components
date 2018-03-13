using System;
using System.IO;
using System.IO.Compression;
using System.Xml.Linq;
using System.Net;
using System.Linq;
using System.Text;

namespace SkiaSharp.Components.Tools.IconConverter
{
    class MainClass
    {

        private static string FormatFloat(string v) 
        {
            if (v == null)
                return "0";
            
            if(v.Contains(',') || v.Contains('.'))
            {
                return v.Replace(",", ".") + "F";
            }
            return v;
        }

        public static void Main(string[] args)
        {
            const string DistantZipUri= "https://github.com/feathericons/feather/archive/master.zip";
            const string LocalZipUri = "feathericons.zip";

            if(!File.Exists(LocalZipUri))
            {
                var client = new WebClient();
                client.DownloadFile(DistantZipUri, LocalZipUri);
            }

            var builder = new StringBuilder();

            builder.AppendLine("/// Source: https://feathericons.com/\n");

            builder.AppendLine("using System;");

            builder.AppendLine("namespace SkiaSharp.Components");
            builder.AppendLine("{");
            builder.AppendLine("    public static class Icons");
            builder.AppendLine("    {");

            string cap = "Round", join = "Round";

            using(var stream = File.OpenRead(LocalZipUri))
            using(var archive = new ZipArchive(stream, ZipArchiveMode.Read))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName.StartsWith("feather-master/icons/", StringComparison.Ordinal) && Path.GetExtension(entry.FullName) == ".svg")
                    {

                        var iconName = string.Join("",Path.GetFileNameWithoutExtension(entry.FullName).Split('-').Select(x => x.Substring(0,1).ToUpper() + x.Substring(1)));

                        builder.AppendLine($"         private static Lazy<Icon> {iconName}Instance = new Lazy<Icon>(() =>");
                        builder.AppendLine("         {");
                        builder.AppendLine("             var source = new SKPath();");

                        using (var content = entry.Open())
                        {
                            var xml = XDocument.Load(content);

                            foreach (var element in xml.Root.Elements())
                            {
                                var name = element.Name.LocalName;
                                var source = "             source";

                                if (name == "line")
                                {
                                    var x1 = FormatFloat(element.Attribute("x1").Value);
                                    var y1 = FormatFloat(element.Attribute("y1").Value);
                                    var x2 = FormatFloat(element.Attribute("x2").Value);
                                    var y2 = FormatFloat(element.Attribute("y2").Value);
                                    builder.AppendLine($"{source}.MoveTo({x1},{y1});");
                                    builder.AppendLine($"{source}.LineTo({x2},{y2});");
                                }
                                else if(name == "polyline" || name == "polygon")
                                {
                                    var points = element.Attribute("points").Value?.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
                                    for (int i = 0; i < points.Count() ; i++)
                                    {
                                        var x = FormatFloat(points.ElementAtOrDefault(i));
                                        i++;
                                        var y = FormatFloat(points.ElementAtOrDefault(i));

                                        if(i == 1)
                                        {
                                            builder.AppendLine($"{source}.MoveTo({x},{y});");
                                            builder.Append($"{source}.AddPoly(new SKPoint [] {{ ");
                                        }
                                        builder.Append($"new SKPoint({x},{y}),");
                                    }
                                    builder.Append("}");
                                    builder.Append($",{ (name == "polygon" ? "true" : "false") }");
                                    builder.AppendLine(");");
                                }
                                else if (name == "circle")
                                {
                                    var cx = FormatFloat(element.Attribute("cx").Value);
                                    var cy = FormatFloat(element.Attribute("cy").Value);
                                    var r = FormatFloat(element.Attribute("r").Value);
                                    builder.AppendLine($"{source}.AddCircle({cx},{cy},{r});");
                                }
                                else if (name == "rect")
                                {
                                    var x = FormatFloat(element.Attribute("x").Value);
                                    var y = FormatFloat(element.Attribute("y").Value);
                                    var w = FormatFloat(element.Attribute("width").Value);
                                    var h = FormatFloat(element.Attribute("height").Value);
                                    builder.AppendLine($"{source}.AddRect(SKRect.Create({x},{y},{w},{h}));");
                                }
                                else if (name == "path")
                                {
                                    builder.Append($"{source}.AddPath(");
                                    builder.Append($"SKPath.ParseSvgPathData(\"{element.Attribute("d").Value}\")");
                                    builder.AppendLine(", SKPathAddMode.Append);");
                                }


                                if (name == "line")
                                {
                                    var x1 = FormatFloat(element.Attribute("x1").Value);
                                    var y1 = FormatFloat(element.Attribute("y1").Value);
                                    var x2 = FormatFloat(element.Attribute("x2").Value);
                                    var y2 = FormatFloat(element.Attribute("y2").Value);
                                    builder.AppendLine($"{source}.MoveTo({x1},{y1});");
                                    builder.AppendLine($"{source}.LineTo({x2},{y2});");
                                }
                            }

                            switch(xml.Root.Attribute("stroke-linecap")?.Value)
                            {
                                case null:
                                    cap = "Round";
                                    break;

                                case "round":
                                    cap = "Round";
                                    break;

                                case "butt":
                                    cap = "Butt";
                                    break;

                                case "square":
                                    cap = "Square";
                                    break;
                            }

                            switch (xml.Root.Attribute("stroke-linejoin")?.Value)
                            {
                                case null:
                                    join = "Round";
                                    break;

                                case "miter":
                                    join = "Miter";
                                    break;

                                case "bevel":
                                    join = "Bevel";
                                    break;
                            }

                            builder.AppendLine($"             return new Icon(source, SKStrokeCap.{cap}, SKStrokeJoin.{join});");
                            builder.AppendLine("         });");
                            builder.AppendLine($"\n         public static Icon {iconName} => {iconName}Instance.Value;");
                        }
                    }
                } 

                

                builder.AppendLine("    }");
                builder.AppendLine("}");
            }

            File.WriteAllText("../../../SkiaSharp.Components/Base/Icons.cs", builder.ToString());

            Console.WriteLine(builder.ToString());
        }
    }
}
