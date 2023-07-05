using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosAleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //for (int m = 0; m < 20; m++) 
            //{
            //    int valor = rnd.Next(0,101);
            //    lista.Items.Add(valor.ToString());
            //}

            for (int m = 0; m < 10; m++) 
            {
                lista.Items.Add(CriarCodigo(m));
            }

        }

        private string CriarCodigo(int seed, int numeroCaracteres = 30) 
        {
            //gerar string com caracteres aleatórios
            StringBuilder sb = new StringBuilder();

            string caracteres = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuvwxyz";
            Random r = new Random(seed);
            int n = r.Next();
            
            for (int vezes = 0; vezes < numeroCaracteres; vezes++)
            {
                Random rnd = new Random(DateTime.Now.Millisecond + seed + n);
                int x = rnd.Next(caracteres.Length);
                sb.Append(caracteres[x]);
                n += 33;
            }


            return sb.ToString();
        }
    }
}
