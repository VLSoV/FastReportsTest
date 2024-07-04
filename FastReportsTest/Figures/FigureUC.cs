using System.Drawing;
using System.Windows.Forms;

namespace FastReportsTest.Figures
{
    public partial class FigureUC : UserControl
    {
        private float _borderThicness = 2;
        private float _height = 100;
        private float _width = 100;
        private Color _borderColor = Color.Black;
        private Color _backgroundColor = Color.Red;

        /// <summary>
        /// Толщина окантовки
        /// </summary>
        public float BorderThicness
        {
            get => _borderThicness;
            set
            {
                if (value > 0)
                {
                    _borderThicness = value;
                }
                else
                {
                    MessageBox.Show("Value must be positive!");
                }
            }
        }

        /// <summary>
        /// Высота фигуры
        /// </summary>
        public float FigureHeight
        {
            get => _height;
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    MessageBox.Show("Value must be positive!");
                }
            }
        }

        /// <summary>
        /// Ширина фигуры
        /// </summary>
        public float FigureWidth
        {
            get => _width;
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    MessageBox.Show("Value must be positive!");
                }
            }
        }

        /// <summary>
        /// Цвет окантовки
        /// </summary>
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
            }
        }

        /// <summary>
        /// Цвет заливки
        /// </summary>
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                _backgroundColor = value;
            }
        }

        public virtual void PaintFigure(Graphics graphics)
        {

        }

        public FigureUC()
        {
            InitializeComponent();
        }

        private void FigureUC_Paint(object sender, PaintEventArgs e)
        {
            PaintFigure(e.Graphics);
        }
    }
}
