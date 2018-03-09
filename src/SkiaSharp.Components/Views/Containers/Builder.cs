using System;

namespace SkiaSharp.Components
{
    public class Builder : View
    {
        public Func<int,View> Factory 
        {
            get => this.factory;
            set => this.SetAndInvalidate(ref this.factory, value);
        } 

        public Func<int,Measure> Measure 
        {
            get => this.measure;
            set => this.SetAndInvalidate(ref this.measure, value);
        }

        public int ItemCount 
        {
            get => this.itemCount;
            set => this.SetAndInvalidate(ref this.itemCount, value);
        }

        #region Fields

        private int itemCount;

        private Func<int,View> factory;

        private Func<int, Measure> measure;

        #endregion

        public View Build(int index) => this.Factory?.Invoke(index);
    }
}
