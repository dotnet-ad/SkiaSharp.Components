using System;
namespace SkiaSharp.Components
{
    public class ViewNodeParser<TView> : NodeParser where TView : View
    {
        public ViewNodeParser(string name = null) : base(name ?? typeof(TView).Name)
        {

        }

        public override View CreateView()
        {
            return Activator.CreateInstance<TView>();
        }

        public ViewNodeParser<TView> WithStyle<T>(string name, Action<Flex.Node, TView, T> setter)
        {
            base.WithStyle<T>(name, (n, v) => setter(n, n.Data as TView, v));
            return this;
        }
    }
}
