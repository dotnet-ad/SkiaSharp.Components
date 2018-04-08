using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SkiaSharp.Components
{
    public class Tap : View
    {
        #region Events

        public event EventHandler Pressed;

        public event EventHandler Released;

        public event EventHandler Tapped;

        #endregion

        private bool isPressed;

        public List<Touch> startedTouches = new List<Touch>();

        public override bool Touch(Touch[] touches)
        {
            var frame = this.AbsoluteFrame;

            foreach (var touch in touches)
            {
                Debug.WriteLine($"Touch at {touch.Position} ({touch.State}) - frame: {this.Frame}");


                if (touch.State == TouchState.Began && frame.Contains(touch.StartPosition))
                {
                    startedTouches.Add(touch);

                    if (!isPressed)
                    {
                        isPressed = true;
                        this.Pressed?.Invoke(this, EventArgs.Empty);
                    }
                }
                if (this.startedTouches.Contains(touch))
                {
                    if (touch.State == TouchState.Ended)
                    {
                        if (frame.Contains(touch.Position) && this.startedTouches.Count == 1)
                        {
                            this.Tapped?.Invoke(this, EventArgs.Empty);
                        }

                        this.startedTouches.Remove(touch);
                    }
                    else if (touch.State == TouchState.Cancelled)
                    {
                        this.startedTouches.Remove(touch);
                    }
                }
            }

            if (isPressed && this.startedTouches.Count == 0)
            {
                isPressed = false;
                this.Released?.Invoke(this, EventArgs.Empty);
            }

            return isPressed;
        }
    }
}
