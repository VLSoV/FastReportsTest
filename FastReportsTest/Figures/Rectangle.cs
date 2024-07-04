using System.Drawing;

namespace FastReportsTest.Figures
{
    public class Rectangle : FigureUC
    {
        public override void PaintFigure(Graphics graphics)
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(BackgroundColor);
            Pen pen = new Pen(BorderColor, BorderThicness);

            graphics.FillRectangle(brush, 0, 0, FigureWidth, FigureHeight);
            graphics.DrawRectangle(pen, BorderThicness / 2, BorderThicness / 2, FigureWidth - BorderThicness, FigureHeight - BorderThicness);
        }
    }
}
