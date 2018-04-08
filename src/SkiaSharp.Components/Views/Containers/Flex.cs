using Facebook.Yoga;

namespace SkiaSharp.Components
{
    public class Flex : Container
    {
        public class Node : YogaNode
        {
            public Node()
            {
            }

            public Node(View view)
            {
                this.Data = view;
            }

            public View View => this.Data as View;
        }

        private Node root;

        public Node Root
        {
            get => this.root;
            set
            {
                if (this.root != null)
                {
                    this.RemoveViews(this.root);
                }

                if (value != null)
                {
                    this.AddViews(value);
                }

                this.SetAndInvalidate(ref root, value);
            }
        }

        protected override void LayoutChildren(SKRect available)
        {
            if(this.root != null)
            {
                this.root.Left = available.Left;
                this.root.Top = available.Top;
                this.root.Width = available.Width;
                this.root.Height = available.Height;

                this.root.CalculateLayout();

                this.ApplyLayout(this.root, SKPoint.Empty);
            }
        }

        private void RemoveViews(YogaNode n)
        {
            if (n.Data is View view)
            {
                this.RemoveView(view);
            }

            foreach (var child in n)
            {
                this.RemoveViews(child);
            }
        }

        private void AddViews(YogaNode n)
        {
            if (n.Data is View view)
            {
                this.AddView(view);
            }

            foreach (var child in n)
            {
                this.AddViews(child);
            }
        }

        private void ApplyLayout(YogaNode n, SKPoint origin)
        {
            if (n.Data is View view)
            {
                origin.X += n.LayoutX;
                origin.Y += n.LayoutY;
                view.LayoutIfNeeded(SKRect.Create(origin.X, origin.Y, n.LayoutWidth, n.LayoutHeight));
            }

            foreach (var child in n)
            {
                this.ApplyLayout(child, origin);
            }
        }
    }
}
