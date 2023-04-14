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

namespace Conversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            StreamWriter ficheiro = new StreamWriter($@"C:\Users\Renan\Desktop\CSharp\Conversao\dados.txt", false, Encoding.Default);

            ficheiro.WriteLine("Esta frase é alfanumérica.");
            
            int valor = 150;
            ficheiro.WriteLine(valor);

            bool resultado = false;
            ficheiro.WriteLine(resultado);

            DateTime dateTime = DateTime.Now;
            ficheiro.WriteLine(dateTime);

            Color cor = Color.FromArgb(30, 125, 232);
            ficheiro.WriteLine(cor.ToArgb());
            //ficheiro.WriteLine(cor);

            ficheiro.Dispose();
        }

        private void cmd_ler_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader($@"C:\Users\Renan\Desktop\CSharp\Conversao\dados.txt", Encoding.Default);
            
            string a = ficheiro.ReadLine();

            //int b = int.Parse(ficheiro.ReadLine());
            int b = Convert.ToInt32(ficheiro.ReadLine());

            bool c = bool.Parse(ficheiro.ReadLine());

            DateTime d = DateTime.Parse(ficheiro.ReadLine());

            Color cor = Color.FromArgb(int.Parse(ficheiro.ReadLine()));
            pictureBox1.BackColor = cor;
                    
            ficheiro.Dispose();
        }
    }
}
