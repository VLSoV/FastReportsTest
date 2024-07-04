using System;
using System.Drawing;

namespace FastReportsTest.Figures
{
    public class Circle : FigureUC
    {
        private float _radius;

        public override void PaintFigure(Graphics graphics)
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(BackgroundColor);
            Pen pen = new Pen(BorderColor, BorderThicness);
            _radius = Math.Min(FigureWidth, FigureHeight);

            graphics.FillEllipse(brush, 0, 0, _radius, _radius);
            graphics.DrawEllipse(pen, BorderThicness / 2, BorderThicness / 2, _radius - BorderThicness, _radius - BorderThicness);
        }
    }
}
