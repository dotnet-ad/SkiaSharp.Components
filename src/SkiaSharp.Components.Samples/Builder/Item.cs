namespace SkiaSharp.Components.Samples
{
    public class Item
    {
        public Item(Icon icon, string title, string description)
        {
            this.Icon = icon;
            this.Title = title;
            this.Description = description;
        }

        public Icon Icon { get; }

        public string Title { get; }

        public string Description { get; }
    }
}
