using FastReportsTest.Figures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FastReportsTest
{
    public partial class Form1 : Form
    {
        private readonly Random _rand = new Random();
        private readonly Color[] colores = new Color[10] { Color.Black, Color.Blue, Color.Red, Color.Green, Color.DarkBlue, Color.DarkRed, Color.DarkGreen, Color.Orange, Color.Purple, Color.SeaShell };
        private int _xOffset = 0;
        private int _yOffset = 50;

        private void CreateFigure(FigureUC figure)
        {
            figure.Location = new System.Drawing.Point(_xOffset, _yOffset);
            _xOffset += figure.Width;

            //figure.Height = (int)figure.FigureHeight;
            //figure.Width = (int)figure.FigureWidth;

            figure.BackgroundColor = colores[_rand.Next(7)];
            figure.BorderColor = colores[_rand.Next(7)];
            figure.BorderThicness = _rand.Next(1,10);

            Controls.Add(figure);
            figure.Refresh();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            CreateFigure(new FastReportsTest.Figures.Rectangle());
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            CreateFigure(new Circle());
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            CreateFigure(new Triangle());
        }
    }
}
