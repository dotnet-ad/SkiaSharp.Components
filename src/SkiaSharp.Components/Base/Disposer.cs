using System;

namespace SkiaSharp.Components
{
    public class Disposer : IDisposable
    {
        public Disposer(Action dispose)
        {
            this.action = dispose;
        }

        private Action action;

        public void Dispose() => this.action();
    }
}
