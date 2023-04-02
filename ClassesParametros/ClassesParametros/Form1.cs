using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesParametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            Teste objeto = new Teste();
            int valor = 10;

            //objeto.Executar(valor);
            //label_txt.Text = valor.ToString();

            //objeto.Acrescentar5(ref valor);
            //label_txt.Text = valor.ToString();

            //valor = objeto.Acrescentar(50);
            //label_txt.Text = valor.ToString();

            valor = objeto.Adicionar(300, 10);
            label_txt.Text = valor.ToString();


        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
