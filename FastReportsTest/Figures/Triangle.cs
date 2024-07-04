using System;
using System.Drawing;
using System.Linq;

namespace FastReportsTest.Figures
{
    public class Triangle : FigureUC
    {
        public override void PaintFigure(Graphics graphics)
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(BackgroundColor);
            Pen pen = new Pen(BorderColor, BorderThicness);
            var points = GetEquilateralTrianglePoints();
            var points2 = ShrinkBorder(points);

            graphics.FillPolygon(brush, points);
            graphics.DrawPolygon(pen, points2);
        }

        /// <summary>
        /// Расчёт координат вершин для равностороннего треугольника (перевернутого)
        /// </summary>
        private PointF[] GetEquilateralTrianglePoints()
        {
            // Треугольник ограничен в ширину
            if (FigureWidth < FigureHeight * 2 / Math.Sqrt(3))
            {
                float sideLength = FigureWidth;
                float height = sideLength * (float)Math.Sqrt(3) / 2;
                return new PointF[]
                {
                    new PointF(0              , FigureHeight / 2 + height / 2),
                    new PointF(FigureWidth / 2, FigureHeight / 2 - height / 2),
                    new PointF(FigureWidth    , FigureHeight / 2 + height / 2),
                };
            }
            // Треугольник ограничен в высоту
            else
            {
                float height = FigureHeight;
                float sideLength = height * 2 / (float)Math.Sqrt(3);
                return new PointF[]
                {
                    new PointF(FigureWidth / 2 - sideLength / 2, FigureHeight),
                    new PointF(FigureWidth / 2, 0),
                    new PointF(FigureWidth / 2  + sideLength / 2, FigureHeight),
                };
            }
        }

        /// <summary>
        /// Уменьшение фигуры для полного помещения бордера, чтобы не обрезался
        /// </summary>
        private PointF[] ShrinkBorder(PointF[] points)
        {
            var width = points[2].X - points[0].X;
            var height = width * (float)Math.Sqrt(3) / 2;
            var koef = (width - BorderThicness) / width;
            var xCenter = FigureWidth / 2;
            var yCenter = FigureHeight / 2;

            return points.Select(point => new PointF(
                    xCenter - (xCenter - point.X) * koef,
                    yCenter - (yCenter - point.Y) * koef
                )).ToArray();
        }
    }
}
