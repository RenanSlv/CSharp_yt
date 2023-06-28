using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoImagem
{
    public partial class Form1 : Form
    {
        string pasta_imagens = "";
        Image img_fundo;

        Image img_normal; // botão normal
        Image img_high; // botão quando o mouse passa por cima do botão
        Image img_disabled; // quando o botão está inativo

        List<cl_bola> bolas;
        int largura;
        int altura;

        public Form1()
        {
            InitializeComponent();
            pasta_imagens = Application.StartupPath + @"\imagens\";
            //carregamento da imagem de fundo
            img_fundo = Image.FromFile($@"{pasta_imagens}foto1.jpg");
            //this.BackgroundImage = img_fundo;

            //pic_test.BackgroundImage = img_fundo;

            Rectangle rect = pic_test.Bounds;

            //mostra a localização da imagem
            //MessageBox.Show($@"{rect.X.ToString()} - {rect.Y.ToString()} | {rect.Width.ToString()} - {rect.Height.ToString()}");



            img_normal = Image.FromFile($@"{pasta_imagens}btn_normal.png");
            img_high = Image.FromFile($@"{pasta_imagens}btn_high.png");
            img_disabled = Image.FromFile($@"{pasta_imagens}btn_disabled.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd_test.BackgroundImage = img_normal;

            largura = pic_test.Width;
            altura = pic_test.Height;

            bolas = new List<cl_bola>();
        }

        private void pic_test_Click(object sender, EventArgs e)
        {
            
        }

        private void pic_test_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pic_test_MouseEnter(object sender, EventArgs e)
        {
            pic_test.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pic_test_MouseLeave(object sender, EventArgs e)
        {
            string img = $@"{Application.StartupPath}\imagens\foto1.jpg";

            pic_test.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pic_test.Location = new Point(0, 0);

            //Rectangle r = pic_test.Bounds;
            //button2.Location = new Point(r.Right, r.Y);

            ////centrar o butao 2 na imagem
            //Rectangle pic_rec = pic_test.Bounds;
            //Rectangle btn_rec = button2.Bounds;

            //button2.Location = new Point(pic_rec.X + pic_rec.Width / 2 - btn_rec.Width / 2,
            //                             pic_rec.Y + pic_rec.Height/2 - btn_rec.Height/2);
        }

        private void cmd_test_MouseEnter(object sender, EventArgs e)
        {
            cmd_test.BackgroundImage = img_high;
        }

        private void cmd_test_MouseLeave(object sender, EventArgs e)
        {
            cmd_test.BackgroundImage = img_normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ativa ou desativa o botão test
            if (cmd_test.Enabled)
                cmd_test.Enabled = false;
            else
                cmd_test.Enabled = true;
        }

        private void button3_EnabledChanged(object sender, EventArgs e)
        {
            if (cmd_test.Enabled)
                cmd_test.BackgroundImage = img_normal;
            else
                cmd_test.BackgroundImage = img_disabled;
        }

        private void cmd_test_Click(object sender, EventArgs e)
        {
            //criar a folha em branco
            //Bitmap imgback = new Bitmap(pic_test.Width,pic_test.Height);
            //Graphics desenhador = Graphics.FromImage(imgback);

            //atribuir uma cor de fundo à Imagem
            //desenhador.Clear(Color.Black);

            ////desenhar um retangulo na imagem
            //Rectangle rect = new Rectangle(50,50,100,80);
            //Pen pen = new Pen(
            //    new LinearGradientBrush(
            //        new Point(0,40),
            //        new Point(0,140), 
            //        Color.Red, 
            //        Color.Green));// para usar o LinearGradientBrush tem que adicionar o Drawing2D
            //pen.Width = 20;
            ////Brush pincel = new SolidBrush(Color.Green);

            //desenhador.DrawRectangle(pen, rect);

            //Pen lapis = new Pen(Color.Black);
            //Pen lapisVermelho = new Pen(Color.Red,3);
            //lapis.Width = 3;

            ////desenhar uma linha
            ////horizontal
            //desenhador.DrawLine(lapis,new Point(50,100), new Point(350,100));

            ////vertical
            //desenhador.DrawLine(lapis, new Point(100, 20), new Point(100, 300));

            ////oblíqua
            //desenhador.DrawLine(lapis, new Point(20, 20), new Point(250, 250));
            //desenhador.DrawLine(lapis, new Point(-50, -100), new Point(200, 200));

            ////desenhar linha quebrada
            //Point[] pontos = new Point[] {
            //    new Point(50,50),
            //    new Point(100,80),
            //    new Point(100,150),
            //    new Point(400,150),
            //    new Point(200,200),
            //    new Point(200,20)
            //};
            //desenhador.DrawLines(lapis, pontos);

            //desenhando retangulos
            //desenhador.DrawRectangle(lapis, new Rectangle(50,80,300,80));
            //desenhador.DrawRectangle(lapis, new Rectangle(80, 30, 70, 280));

            //desenhar um circulo
            //desenhador.DrawRectangle(lapisVermelho, new Rectangle(100, 100, 200, 200));
            //desenhador.DrawEllipse(lapis, new Rectangle(100, 100, 200, 200));

            //Brush pincel = new SolidBrush(Color.Red);
            //Brush pincel1 = new LinearGradientBrush(new Point(50,50),new Point(350,300),Color.Red,Color.Yellow);
            //Brush pincel2 = new LinearGradientBrush(new Point(50, 50), new Point(50, 300), Color.Red, Color.Yellow);
            //Brush pincel3 = new LinearGradientBrush(new Point(150, 50), new Point(250, 50), Color.Red, Color.Yellow);

            //Brush pincel = new SolidBrush(Color.Red);
            //Brush pincel1 = new LinearGradientBrush(new Point(150, 50), new Point(250, 50), Color.Red, Color.Yellow);
            //Brush pincel2 = new SolidBrush(Color.Yellow);

            //desenhador.FillRectangle(pincel, new Rectangle(50, 50, 100, 250));
            //desenhador.FillRectangle(pincel1, new Rectangle(150, 50, 100, 250));
            //desenhador.FillRectangle(pincel2, new Rectangle(250, 50, 100, 250));

            //desenhador.FillEllipse(pincel, new Rectangle(50,50,200,200));

            //Rectangle rect = new Rectangle(50,50,200,200);
            //desenhador.FillRectangle(pincel2,rect);
            //desenhador.DrawRectangle(lapis,rect);

            //ESCREVENDO NA IMAGEM
            //string texto = "Frase teste";
            //Font letra = new Font("Courrier",40,FontStyle.Bold | FontStyle.Italic,GraphicsUnit.Pixel);
            //Brush pincel = new SolidBrush(Color.Red);
            //Brush pincel1 = new SolidBrush(Color.Black);
            //Point inicio = new Point(50,50);
            //Point inicio_sombra = new Point(53,53);
            //desenhador.DrawString(texto,letra,pincel1,inicio_sombra);
            //desenhador.DrawString(texto,letra,pincel,inicio);

            ////separando um espaço para o texto na imagem
            //string texto = "Num ninho de mafagafos há sete mafagafinhos. Quando a mafagafa gafa, gafam os sete mafagafinhos.Trazei três pratos de trigo para três tigres tristes comerem.A aranha arranha a rã;
            //Brush cor = new SolidBrush(Color.Black);
            //Font letra = new Font("Arial", 12, FontStyle.Regular,GraphicsUnit.Pixel);
            //Rectangle rect = new Rectangle(50,50,300,210);
            //string texto1 = "Texto test";
            //StringFormat alinhamento = new StringFormat();
            //alinhamento.Alignment = StringAlignment.Center;//alinha na horizontal
            //alinhamento.LineAlignment = StringAlignment.Center;//alinha na vertical

            //desenhador.DrawRectangle(lapis,rect);
            ////desenhador.DrawString(texto,letra,cor,rect);
            //desenhador.DrawString(texto1, letra, cor, rect,alinhamento);

            //Image original = Image.FromFile(pasta_imagens + "foto1.jpg");

            ////cortar e colar a imagem
            //desenhador.DrawImage(original,new Rectangle(50,50,50,50), new Rectangle(340,420,50,50),GraphicsUnit.Pixel);
            //desenhador.DrawImage(original, new Rectangle(150, 50, 50, 50), new Rectangle(340, 420, 250, 250), GraphicsUnit.Pixel);
            //desenhador.DrawImage(original, new Rectangle(250, 50, 250, 250), new Rectangle(340, 420, 50, 50), GraphicsUnit.Pixel);

            //Image bola = Image.FromFile(pasta_imagens + "bolabr_pequena.png");
            //desenhador.DrawImage(bola, new Rectangle(100,100,50,50),new Rectangle(0,0,75,75),GraphicsUnit.Pixel);


            ////apresenta a imagem final
            //pic_test.BackgroundImage = imgback;

            cl_bola b = new cl_bola();
            bolas.Add(b);
            tempo.Enabled = true;
            //x += 10;
            //desenhar();

        }

        private void Desenhar() 
        {

            //criar a folha em branco
            Bitmap imgback = new Bitmap(pic_test.Width, pic_test.Height);
            Graphics desenhador = Graphics.FromImage(imgback);

            //atribuir uma cor de fundo à Imagem
            desenhador.Clear(Color.Black);
            Image img_bola = Image.FromFile(pasta_imagens + "bolabr_pequena.png");
            //desenhador.DrawImage(bola, new Rectangle(x, 100, 50, 50), new Rectangle(0, 0, 75, 75), GraphicsUnit.Pixel);
            //desenhador.DrawImage(bola,new Rectangle(x,y,50,50), new Rectangle(0,0,50,50),GraphicsUnit.Pixel);

            //ciclo que percorre todas as bolas existentes
            foreach (cl_bola bola in this.bolas) 
            {
                bola.Mover(largura,altura);
                desenhador.DrawImage(img_bola,
                                    new Rectangle(bola.x, bola.y, 50, 50),
                                    new Rectangle(0, 0, 50, 50),
                                    GraphicsUnit.Pixel);
            }

            //apresenta a imagem final
            pic_test.BackgroundImage = imgback;


        }
        private void cmd_test_EnabledChanged(object sender, EventArgs e)
        {
            if (cmd_test.Enabled)
                cmd_test.BackgroundImage = img_normal;
            else
                cmd_test.BackgroundImage = img_disabled;
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            ////movar a image
            //x += 10;
            //Desenhar();
            //if(x>=500)
            //    tempo.Enabled=false;


            Desenhar();


        }
    }
}
