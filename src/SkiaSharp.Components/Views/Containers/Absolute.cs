using System;
using System.Collections.Generic;

namespace SkiaSharp.Components
{
    public class Absolute : Container
    {
        #region Fields

        private Dictionary<View,Func<SKRect,SKRect>> positions = new Dictionary<View, Func<SKRect, SKRect>>();

        #endregion

        public override void RemoveView(View subview)
        {
            if(this.positions.ContainsKey(subview))
            {
                positions.Remove(subview);
            }

            base.RemoveView(subview);
        }

        public void AddView(View subview, Func<SKRect, SKRect> position)
        {
            this.AddView(subview);
            this.positions[subview] = position;
        }

        protected override void LayoutChildren(SKRect available)
        {
            foreach (var child in this.Children)
            {
                if(this.positions.TryGetValue(child, out Func<SKRect, SKRect> calculate))
                {
                    var position = calculate(available);
                    var left = position.Left;
                    var top = position.Top;
                    var w = Math.Min(position.Width, available.Width - position.Left);
                    var h = Math.Min(position.Height, available.Height - position.Top);
                    child.Layout(SKRect.Create(left, top, w, h));
                }
            }
        }
    }
}
