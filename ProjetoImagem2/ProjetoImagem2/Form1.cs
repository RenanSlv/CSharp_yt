using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoImagem2
{
    public partial class Form1 : Form
    {

        Image img_frame;
        int largura;
        int altura;
        public Form1()
        {
            this.DoubleBuffered = true; //melhora o flick
            InitializeComponent();
            img_frame =  Image.FromFile(Environment.CurrentDirectory + @"\images\quadrado.png");
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            largura = this.ClientRectangle.Width;
            altura = this.ClientRectangle.Height;
            DesenhaGUI();
        }

        private void DesenhaGUI()
        {
            //desenha o fundo do formulario
            Bitmap imgback = new Bitmap(largura,altura);
            Graphics desenhador = Graphics.FromImage(imgback);

            //desenhar os cantos
            //40x40 - 200x200
            //40x40
            //160x40

            //desenha o canto superior esquerdo
            desenhador.DrawImage(img_frame, new Rectangle(0,0,40,40), new Rectangle(0,0,40,40), GraphicsUnit.Pixel);
            //desenha o canto superior direito
            desenhador.DrawImage(img_frame, new Rectangle(largura-40,0,40,40), new Rectangle(160,0,40,40),GraphicsUnit.Pixel);
            //desenha o canto inferior esquerdo
            desenhador.DrawImage(img_frame, new Rectangle(0, altura-40, 40, 40), new Rectangle(0, 160, 40, 40), GraphicsUnit.Pixel);
            //desenha o canto inferior direito
            desenhador.DrawImage(img_frame, new Rectangle(largura - 40, altura-40, 40, 40), new Rectangle(160, 160, 40, 40), GraphicsUnit.Pixel);

            //desenha as linhas horizontais
            desenhador.DrawImage(img_frame, new Rectangle(40,0,largura-80,40), new Rectangle(40,0,120,40),GraphicsUnit.Pixel);
            desenhador.DrawImage(img_frame, new Rectangle(40,altura-40,largura-80,40), new Rectangle(40,160,120,40),GraphicsUnit.Pixel);
            //desenha as linhas verticais
            desenhador.DrawImage(img_frame, new Rectangle(0, 40, 40, altura-80), new Rectangle(0, 40, 40, 120), GraphicsUnit.Pixel);
            desenhador.DrawImage(img_frame, new Rectangle(largura-40,40,40,altura-80), new Rectangle(160, 40, 40, 120), GraphicsUnit.Pixel);

            //definir a imagem de fundo de Form1
            this.BackgroundImage = imgback;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            label_size.Text = this.ClientRectangle.Width.ToString() + " - " + this.ClientRectangle.Height.ToString();
            largura = this.ClientRectangle.Width;
            altura = this.ClientRectangle.Height;
            DesenhaGUI();
        }
    }
}
