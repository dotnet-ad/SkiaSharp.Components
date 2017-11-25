using System.Diagnostics;
namespace SkiaSharp.Components.Samples
{
    public class FlexView : View
    {
        public Layout Root { get; }

        public FlexView()
        {
            this.Root = new Layout(this);
        }

        public override void Layout(SKRect frame)
        {
            Debug.WriteLine("<Layout>");

            this.Root.Width = frame.Width;
            this.Root.Height = frame.Height;
            this.Root.Left = frame.Left;
            this.Root.Top = frame.Top;

            this.Root.CalculateLayout();
            this.Root.Apply();
        }

        public T AddView<T>(Layout<T> child)  where T : View => this.Root.AddView(child);

        public void AddViews(params Layout[] children) =>this.Root.AddViews(children);
    }
}
