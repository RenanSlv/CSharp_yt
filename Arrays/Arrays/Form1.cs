using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //ARRAYS

            //int[] valores;
            //valores = new int[5];

            //valores[0] = 0;
            //valores[1] = 10;
            //valores[2] = 20;
            //valores[3] = 30;
            //valores[4] = 40;

            //foreach (int contador in valores) 
            //{
            //    lista.Items.Add(contador);
            //}
            //for (int i = 0; i<5; i++) 
            //{
            //    lista.Items.Add(valores[i]);
            //}

            //declarações diferentes de array
            //int[] valores = new int[5];
            int[] valores = new int[] {10, 20, 30, 40, 50};

            foreach (int valor in valores)
                lista.Items.Add(valor);
            
            //for(int i = 0 ; i < valores.Length; i++)
            //  lista.Items.Add(valores[i]);

        }
    }
}
