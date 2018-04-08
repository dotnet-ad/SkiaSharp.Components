using SkiaSharp.Components.Markup;
using SkiaSharp.Components.Markup.Live;

namespace SkiaSharp.Components.Samples
{
    public static class App
    {
        public static void Initialize()
        {
            Image.Client = new Image.MemoryCacheClient(new Image.HttpClient(new System.Net.Http.HttpClient()), 20);

            var live = new LiveClient();
            live.StartAsync("ws://192.168.2.45:81");
            Development.Current = live;
        }
    }
}
