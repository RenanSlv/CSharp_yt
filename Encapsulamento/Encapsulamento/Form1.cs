using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //apresenta o preço final do produto
            cl_calculo calculadora = new cl_calculo();
            int precoInicial = int.Parse(textBox_preco.Text);
            // int precoInicial = Convert.ToInt16(textBox_preco.Text);

            int tipoProduto;
            if (radioButton_leite.Checked)
                tipoProduto = 1;
            else if (radioButton_martelo.Checked)
                tipoProduto = 2;
            else if (radioButton_perfume.Checked)
                tipoProduto = 3;
            else
                tipoProduto = 0;

            MessageBox.Show($@"Preço final = {calculadora.CalcularPrecoFinal(precoInicial,tipoProduto)}");
        }
    }
}
