using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataHora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {

            //label_resultado.Text = DateTime.Today.ToString();
            //label_resultado.Text = DateTime.Now.ToString();
            //label_resultado.Text = DateTime.Now.ToString("yyyy/MM/dd");

            //DateTime data = new DateTime(1989, 01, 21);
            //label_resultado.Text = data.DayOfWeek.ToString();

            int dia = int.Parse(textBox_dia.Text);
            int mes = int.Parse(textBox_mes.Text);
            int ano = int.Parse(textBox_ano.Text);

            DateTime data = new DateTime(ano, mes, dia);
            label_resultado.Text = $@"I was born in a {data.DayOfWeek.ToString()}";

        }
    }
}
