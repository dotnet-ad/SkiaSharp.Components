using System;
using Facebook.Yoga;

namespace SkiaSharp.Components.Samples
{
    public class CellSample : Flex
    {
        #region Properties

        public Label Title { get; }

        public Label Description { get; }

        public Box Box { get; }

        public Path Icon { get; }

        #endregion

        public CellSample(Item item)
        {
            this.Title = new Label
            {
                TextSize = 30,
                Text = item.Title,
                VerticalAlignment = Alignment.Center,
            };

            this.Description = new Label
            {
                TextSize = 16,
                Text = item.Description
            };

            var gradient = new GradientBrush(new SKPoint(0, 0), new SKPoint(0, 1), new[]
            {
                new Tuple<float, SKColor>(0, new SKColor(255,255,255,255)),
                new Tuple<float, SKColor>(1, new SKColor(238,238,238,255)),
            });

            var shadow = new Shadow(SKPoint.Empty, new SKPoint(10, 10), SKColors.Black.WithAlpha(80));

            this.Box = new Box()
            {
                Fill = gradient,
                CornerRadius = 5.0f,
                Shadow = shadow,
            };

            var iconGradient = new GradientBrush(new SKPoint(0, 0), new SKPoint(1, 1), new[]
            {
                new Tuple<float, SKColor>(0, new SKColor(0xFFF44336)),
                new Tuple<float, SKColor>(1, new SKColor(0xFF3F51B5)),
            });

            this.Icon = new Path
            {
                Source = item.Icon,
                ViewBox = SKRect.Create(0, 0, 24, 24),
                Stroke = new Stroke(3, iconGradient, StrokeStyle.Line),
            };

            // Layout 

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

            this.Root = root;

        }
    }
}
