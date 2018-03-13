using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace SkiaSharp.Components
{
    public class Image : Box
    {
        public interface IClient
        {
            Task<SKBitmap> GetAsync(string url);
        }

        public class HttpClient : IClient
        {
            private System.Net.Http.HttpClient client;

            public HttpClient(System.Net.Http.HttpClient client)
            {
                this.client = client;
            }

            public async Task<SKBitmap> GetAsync(string url)
            {
                using (var response = await client.GetStreamAsync(url))
                {
                    var bitmap = SKBitmap.Decode(response);
                    if (bitmap == null)
                        throw new Exception("Failed to decode image");
                    return bitmap;
                }
            }
        }

        public class MemoryCacheClient : IClient
        {
            List<Tuple<string, SKBitmap>> cache = new List<Tuple<string, SKBitmap>>();

            private IClient client;

            private int max;

            public MemoryCacheClient(IClient client, int max)
            {
                this.client = client;
                this.max = max;
            }

            public async Task<SKBitmap> GetAsync(string url)
            {
                var bitmap = cache.FirstOrDefault(x => x.Item1 == url)?.Item2;

                if (bitmap == null)
                {
                    bitmap = await this.client.GetAsync(url);

                    if(cache.Count >= max)
                    {
                        cache.RemoveAt(0);
                    }

                    cache.Add(new Tuple<string, SKBitmap>(url, bitmap));
                }

                return bitmap;
            }
        }

        public string Source
        {
            get => this.source;
            set
            {
                if (this.source != value)
                {
                    this.source = value;
                    this.LoadImage();
                }
            }
        }

        #region Fields

        private string source;

        public static IClient Client { get; set; } = new HttpClient(new System.Net.Http.HttpClient());

        #endregion

        #region Methods

        private void LoadImage()
        {
            Task.Run(async () =>
            {
                try
                {
                    var bitmap = await Client.GetAsync(this.source);
                    this.Fill = new ImageBrush(bitmap, 1.0f);

                }
                catch (System.Exception ex)
                {
                    this.Fill = new ColorBrush(SKColors.Red);
                }
            });
        }

        #endregion
    }
}
