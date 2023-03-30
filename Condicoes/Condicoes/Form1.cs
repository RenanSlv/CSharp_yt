using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //int valor = 5;
            //// IF ELSE
            //if (valor == 2 || valor == 5)
            //{
            //    label_resultado.Text = "Entrou no if";
            //}
            //else
            //{
            //    label_resultado.Text = "Não entrou no if";
            //}

            //SWITCH
            //int valor = 20;
            //switch (valor) 
            //{
            //    case 10:
            //        label_resultado.Text = "Entrou no Switch";
            //        break;

            //    case 1:
            //        valor = 2;
            //        break;

            //    default:
            //        label_resultado.Text = "Não entrou no Switch";
            //        break;
            //}

            //OPERADOR TERNÁRIO
            int valor = 10;

            label_resultado.Text = valor == 10 ? "Sim" : "Não";

            string resultadofinal = valor == 10 ? "SIM" : "NÃO";
            label_resultado.Text = resultadofinal;
 
        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
