using System.Collections.Generic;
using System.Linq;
using System;

namespace SkiaSharp.Components
{
    public class Grid : Container
    {
        #region Inner helpers

        public enum Unit
        {
            Points,
            Stars,
        }

        public class Definition
        {
            private Definition(float size, Unit unit)
            {
                this.Size = size;
                this.Unit = unit;
            }

            public float Size { get; }

            public Unit Unit { get; }

            public static Definition Stars(float size) => new Definition(size, Unit.Stars);

            public static Definition Points(float size) => new Definition(size, Unit.Points);

            public static Definition Default = Stars(1);
        }

        public class Position
        {
            public Position(View v)
            {
                this.View = v;
            }

            public View View { get; }

            public int Column { get; set; } = 0;

            public int Row { get; set; } = 0;

            public int ColumnSpan { get; set; } = 1;

            public int RowSpan { get; set; } = 1;
        }

        #endregion

        #region Properties

        public float RowSpacing 
        {
            get => this.rowSpacing;
            set => this.SetAndInvalidate(ref this.rowSpacing, value);
        } 

        public float ColumnSpacing 
        {
            get => this.columnSpacing;
            set => this.SetAndInvalidate(ref this.columnSpacing, value);
        } 

        public IEnumerable<Definition> ColumnDefinitions 
        {
            get => this.columnDefinitions ?? new [] { Definition.Default };
            set => this.SetAndInvalidate(ref this.columnDefinitions, value);
        } 

        public IEnumerable<Definition> RowDefinitions
        {
            get => this.rowDefinitions ?? new[] { Definition.Default };
            set => this.SetAndInvalidate(ref this.rowDefinitions, value);
        }

        public IEnumerable<Position> Positions => this.positions;

        #endregion

        #region Fields

        private IEnumerable<Definition> columnDefinitions, rowDefinitions;

        private List<Position> positions = new List<Position>();

        private float rowSpacing, columnSpacing;

        public Position GetPosition(View v) => this.positions.FirstOrDefault(x => x.View == v);

        public override void AddView(View subview)
        {
            base.AddView(subview);
            this.positions.Add(new Position(subview));
        }

        public override void RemoveView(View subview)
        {
            var position = GetPosition(subview);
            this.positions.Remove(position);
            base.RemoveView(subview);
        }

        public Grid AddView(View subview, int column, int row, int columnSpan = 1, int rowSpan = 1)
        {
            this.AddView(subview);
            var position = this.GetPosition(subview);
            position.Column = column;
            position.Row = row;
            position.ColumnSpan = columnSpan;
            position.RowSpan = rowSpan;
            return this;
        }

        private SKRect[,] CalculateCellSizes(SKRect available)
        {
            // Row sizes
            var rows = this.RowDefinitions.Count();
            var totalRowStars = this.RowDefinitions.Where(x => x.Unit == Unit.Stars).Sum(x => x.Size);
            var fixedRowSize = this.RowDefinitions.Where(x => x.Unit == Unit.Points).Sum(x => x.Size) - RowSpacing * (rows - 1);
            var remainingRowSize = Math.Max(0, available.Height - fixedRowSize);
            var rowSizes = this.RowDefinitions.Select(x =>
            {
                switch (x.Unit)
                {
                    case Unit.Stars:
                        return remainingRowSize * (x.Size / totalRowStars);
                    default:
                        return x.Size;
                }
            }).ToArray();

            // Column sizes
            var columns = this.ColumnDefinitions.Count();
            var totalColmunStars = this.ColumnDefinitions.Where(x => x.Unit == Unit.Stars).Sum(x => x.Size);
            var fixedColumnSize = this.ColumnDefinitions.Where(x => x.Unit == Unit.Points).Sum(x => x.Size) - ColumnSpacing * (columns - 1);
            var remainingColumnSize = Math.Max(0, available.Width - fixedColumnSize);
            var columnSizes = this.ColumnDefinitions.Select(x =>
            {
                switch (x.Unit)
                {
                    case Unit.Stars:
                        return remainingColumnSize * (x.Size / totalColmunStars);
                    default:
                        return x.Size;
                }
            }).ToArray();

            // CellSizes
            var cellSizes = new SKRect[columns, rows];
            float left = 0, top = 0;
            for (int column = 0; column < columns; column++)
            {
                var width = columnSizes[column];

                for (int row = 0; row < rows; row++)
                {
                    var height = rowSizes[row];
                    cellSizes[column, row] = SKRect.Create(left, top, width, height);
                    top += height + RowSpacing;
                }

                left += width + ColumnSpacing;
                top = 0;
            }

            return cellSizes;
        }

        protected override void LayoutChildren(SKRect available)
        {
            var cellSizes = CalculateCellSizes(available);

            // Layout of children
            foreach (var position in this.Positions)
            {
                var location = cellSizes[position.Column, position.Row].Location;
                var width = Enumerable.Range(position.Column, position.ColumnSpan).Sum(x => cellSizes[x, 0].Width);
                var height = Enumerable.Range(position.Row, position.RowSpan).Sum(x => cellSizes[0, x].Height);
                position.View.Layout(SKRect.Create(location, new SKSize(width,height)));
            }
        }

        #endregion
    }

}
