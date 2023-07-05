using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValoresNumericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //byte pequeno = 5;
            ////byte.MaxValue;

            //int inteiro = 10;
            ////int.MinValue;

            //uint novovalor = 20;
            ////valores inteiros apenas positivos

            //long longo = 100;

            //==============================================================//
            //converter texto para valores inteiros
            //int res = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            //int res = int.Parse(textBox1.Text) + Convert.ToInt32(textBox2.Text);

            //int n1 =0,
            //    n2 =0;

            //int.TryParse(textBox1.Text,out n1);
            //int.TryParse(textBox2.Text,out n2);

            //int res = n1 + n2;

            //label_resultados.Text = $@"O valor é : {res.ToString()}" ;

            //==============================================================//
            //double valor1 = 1.445;
            ////double valor2 = 1.1;
            //double res = valor1;

            //label_resultados.Text = res.ToString("0.00");
            //double res2 = double.Parse(label_resultados.Text);

            //double valor1 = 1.123;
            //double res = Math.Round(valor1, 1);
            //double res1 = Math.Floor(valor1); // arredonda apenas para o valor inteiro mesmo 1.9 arredonda para 1
            //double res2 = Math.Ceiling(valor1); // arredonda para cima mesmo sendo 1.1 arredonda para 2


            //label_resultados.Text = res2.ToString();

            //==============================================================//

            byte v = 1;
            bool valor = Convert.ToBoolean(v); 

            label_resultados.Text = valor.ToString();

        }
    }
}
