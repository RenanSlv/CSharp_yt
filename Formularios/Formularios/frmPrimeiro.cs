using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmPrimeiro : Form
    {
        public frmPrimeiro()
        {
            InitializeComponent();
        }

        private void cmd_1_Click(object sender, EventArgs e)
        {
            Geral.Nome = textBox_nome.Text; // passando Nome pela classe estatica
            frmUm formulario = new frmUm(textBox_nome.Text);
            formulario.ShowDialog();
        }

        private void cmd_2_Click(object sender, EventArgs e)
        {
            frmDois formulario = new frmDois();
            formulario.ShowDialog();
        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
