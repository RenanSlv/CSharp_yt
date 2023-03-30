using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            ////FOR
            //for (int i = 0; i<=100; i += 2)
            //lista.Items.Add(i);

            ////WHILE
            //int i = 0;
            //while (i <= 100)
            //{
            //    lista.Items.Add(i++);
            //}

            //DO_WHILE
            //int i = 0;
            //do
            //{
            //    lista.Items.Add(i++);

            //} while (i<=100);

            //FOREACH
            string frase = "Este ciclo é fantástico.";

            lista.Items.Add(frase);
            lista.Items.Add(frase.ToUpper());
            lista.Items.Add(frase.Length);

            foreach (char c in frase) 
            {
                lista.Items.Add(c);
            }

            List<string> lista_nomes = new List<string>() 
            {
                "João", "Anônio", "Francisco", "Carlos", "Ana", "Patricia", "Joana"
            };
                        
            foreach (string nomes in lista_nomes)
            {
                lista.Items.Add(nomes);
            }



        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
