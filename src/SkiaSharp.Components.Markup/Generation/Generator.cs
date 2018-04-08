using System.Text;
using System.Linq;

namespace SkiaSharp.Components.Markup
{
    using System;

    public class Generator
    {
        public Generator()
        {
        }

        protected void Reset()
        {
            this.id = 0;
            this.builder = new StringBuilder();
        }

        protected int NewId() => ++this.id;

        private int scope, id;

        private const int padding = 4;

        protected StringBuilder builder;

        #region Utils

        protected Generator Append(string value, bool withScope = true)
        {
            builder.Append($"{new String(' ', padding * (withScope ? scope : 0))}{value}");
            return this;
        }

        protected Generator AppendLine(string value, bool withScope = true)
        {
            this.Append(value, withScope);
            builder.AppendLine();
            return this;
        }

        protected Generator OpenBody()
        {
            this.AppendLine("{");
            scope++;
            return this;
        }

        protected Generator CloseBody()
        {
            scope--;
            this.AppendLine("}");
            return this;
        }

        protected Generator Body(Action action)
        {
            this.OpenBody();
            action();
            return this.CloseBody();
        }

        #endregion
    }
}