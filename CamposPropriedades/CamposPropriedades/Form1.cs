using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamposPropriedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            Teste valor = new Teste();

            //valor.nome = "João";
            //valor.Apresentar();

            valor.Nome = text_box1.Text;
            valor.Apelido = text_box3.Text;
            valor.Idade = int.Parse(text_box2.Text);

            label_txt.Text = valor.Nome + " " + valor.Idade.ToString();
            valor.Apresentar();
        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
