namespace SkiaSharp.Components
{
    public class Stack : Container
    {
        protected override void LayoutChildren(SKRect available)
        {
            var bounds = SKRect.Create(SKPoint.Empty, available.Size);

            foreach (var child in this.Children)
            {
                child.Layout(bounds);
            }
        }
    }
}
