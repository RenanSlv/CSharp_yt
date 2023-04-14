using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CaixasDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox

            //informação simples
            //MessageBox.Show("Mensagem");

            //botões, icone, título
            //MessageBox.Show("Texto da mensagem",
            //                "Título",
            //                MessageBoxButtons.YesNo,
            //                MessageBoxIcon.Information);

            //caixa de diálogo com resultado
            if (MessageBox.Show("Deseja sair da Aplicação",
                            "SAIR",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("Não");
                return;
            }
            else 
            {
                MessageBox.Show("Sim");
                Application.Exit();
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            caixa.Title = "ESCOLHER FICHEIRO";
            caixa.InitialDirectory = $@"C:\";
            caixa.Filter = @"ficheiros TXT (*.txt)|*.txt|
Jpeg Imagens|*.jpg|
BMP files(*.bmp)|*.bmp";

            if(caixa.ShowDialog()== DialogResult) return;

            //abre o ficheiro
            MessageBox.Show("O utilizador utilizou o ficheiro " + caixa.FileName );

            pictureBox1.BackgroundImage = Image.FromFile( caixa.FileName );
            caixa.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog caixa = new SaveFileDialog();
            caixa.Title = "GRAVAR FICHEIRO";
            caixa.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            caixa.Filter = "TXT files (*.txt)|*.txt";

            if(caixa.ShowDialog() == DialogResult.Cancel) return;

            //grava o ficheiro
            string ficheiro = caixa.FileName;

            StreamWriter arquivo = new StreamWriter(ficheiro, false, Encoding.Default);
            arquivo.WriteLine("testando");
            arquivo.Dispose();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog caixa = new FolderBrowserDialog();
            caixa.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            //retorna a pasta selecionada
            MessageBox.Show("A pasta selecionada foi " + caixa.SelectedPath);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog caixa = new ColorDialog();
            caixa.Color = pictureBox1.BackColor;

            if (caixa.ShowDialog() == DialogResult.Cancel) return;

            pictureBox1.BackColor = caixa.Color;
                       
        }
    }
}
