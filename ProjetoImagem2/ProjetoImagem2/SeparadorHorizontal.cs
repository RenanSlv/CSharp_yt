using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoImagem2
{
    public partial class SeparadorHorizontal : UserControl
    {
        //propriedade
        private byte _alphaEscuro = 100;
        private byte _alphaClaro = 200;
        private Color _corEscura = Color.Black;
        private Color _corClara = Color.White;

        //implementar as propriedades
        public byte AlphaEcuro
        {
            get { return _alphaEscuro; }
            set 
            { 
                _alphaEscuro = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
        }

        public byte AlphaClaro
        {
            get { return _alphaClaro; }
            set 
            {
                _alphaClaro = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
        }

        public Color CorEscura 
        {
            get { return _corEscura; }
            set 
            { 
                _corEscura = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
        }

        public Color CorClara 
        {
            get { return _corClara; }
            set
            {
                _corClara = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
        }


        public SeparadorHorizontal()
        {
            InitializeComponent();

            //caracteristica genéricas
            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.None;
            SeparadorHorizontal_Resize(this, EventArgs.Empty);
        }

        private void SeparadorHorizontal_Load(object sender, EventArgs e)
        {

        }

        private void SeparadorHorizontal_Resize(object sender, EventArgs e)
        {
            //desenhar as linhas (aspecto visual do controle)
            this.Height = 4;

            Bitmap imgback = new Bitmap(this.Width, this.Height);
            Graphics desenhador = Graphics.FromImage(imgback);

            //criar as pens
            Pen penClara = new Pen(Color.FromArgb(_alphaClaro, _corClara), 1);
            Pen penEscura = new Pen(Color.FromArgb(_alphaEscuro, _corEscura), 1);

            //desenhar as linhas
            desenhador.DrawLine(penEscura, new Point(1,1), new Point(this.Width-3,1));
            desenhador.DrawLine(penEscura, new Point(1,1), new Point(1,2));

            desenhador.DrawLine(penClara, new Point(2, 2), new Point(this.Width - 2, 2));
            desenhador.DrawLine(penClara, new Point(this.Width-2, 1), new Point(this.Width-2,2));

            this.BackgroundImage = imgback;
        }
    }
}
