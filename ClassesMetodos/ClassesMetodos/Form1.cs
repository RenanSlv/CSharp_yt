using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesMetodos
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
            cl_matematica calculadora = new cl_matematica();
            int resultado;
            //resultado = calculadora.Adicao(10, 20);
            //resultado = calculadora.Subtracao(100,50);
            //resultado = calculadora.Multiplicacao(20, 5);
            //resultado = calculadora.Divisao(100,10);

            resultado = calculadora.Operacoes(10,5,"+");

            label_txt.Text = resultado.ToString();
        }
    }
}
