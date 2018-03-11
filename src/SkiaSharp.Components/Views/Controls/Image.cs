using System.IO;
using System.Net.Http;

namespace SkiaSharp.Components
{
    public class Image : Box
    {
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

        private HttpClient client = new HttpClient();

        #endregion

        #region Methods

        private async void LoadImage()
        {
            try
            {
                using (var response = await client.GetStreamAsync(this.source))
                {
                    var memory = new MemoryStream();
                    response.CopyTo(memory);
                    this.Fill = new ImageBrush(() =>
                    {
                        var copy = new MemoryStream();
                        memory.Seek(0, SeekOrigin.Begin);
                        memory.CopyTo(copy);
                        copy.Seek(0, SeekOrigin.Begin);
                        return copy;
                    }, 1.0f);
                }
            }
            catch (System.Exception ex)
            {
                this.Fill = new ColorBrush(SKColors.Red);
            }
        }

        #endregion
    }
}
