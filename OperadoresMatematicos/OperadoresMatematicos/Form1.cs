using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresMatematicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //int parcela1 = int.Parse(text_parcela_1.Text);
            //int parcela2 = int.Parse(text_parcela_2.Text);
            //int resultado;            

            ////Adição (+)
            //resultado = parcela1 + parcela2;

            ////Subtração (-)
            //resultado = parcela1 - parcela2;

            ////Multiplicação (*)
            //resultado = parcela2 * parcela1;

            ////Divisão (/)
            //resultado = parcela1 / parcela2;

            ////Modulo (resto da divisão %)
            //resultado = parcela1 % parcela2;
            //-------------------------------------------------------------------
            int resultado = 50;

            resultado += 5;
            resultado++;
            ++resultado;

            label_resultado.Text = (++resultado).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
