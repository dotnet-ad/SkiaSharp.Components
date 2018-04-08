using System;
namespace SkiaSharp.Components.Samples
{
    public static class App
    {
        public static void Initialize()
        {
            Image.Client = new Image.MemoryCacheClient(new Image.HttpClient(new System.Net.Http.HttpClient()), 20);
        }
    }
}
