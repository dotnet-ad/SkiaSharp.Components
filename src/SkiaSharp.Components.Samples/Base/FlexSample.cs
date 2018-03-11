using Facebook.Yoga;

namespace SkiaSharp.Components.Samples
{
    public class FlexSample : SampleBase
    {
        public override View Build()
        {
            var root = new Flex.Node();

            var row1 = new Flex.Node()
            {
                FlexDirection = YogaFlexDirection.Row,
                Height = 140,
            };

            row1.AddChild(new Flex.Node(this.Icon)
            {
                Width = 100,
                Margin = 20.0f,
            });

            row1.AddChild(new Flex.Node(this.Title)
            {
                Flex = 1,
                AlignSelf = YogaAlign.Stretch,
            });

            root.AddChild(row1);

            var descNode = new Flex.Node(this.Description)
            {
                Margin = 20,
                AlignSelf = YogaAlign.Stretch,
            };

            var boxNode = new Flex.Node(this.Box)
            {
                Margin = 20,
                Padding = 20,
            };

            boxNode.AddChild(descNode);

            root.AddChild(boxNode);

            root.AddChild(new Flex.Node(this.Image)
            {
                Margin = 20,
                AlignSelf = YogaAlign.Stretch,
                Flex = 1,
            });

            return new Flex()
            {
                Root = root,
            };
        }
    }
}
