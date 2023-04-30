using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda1
{
    public partial class frmPesquisa : Form
    {
        //propriedade de controle
        public bool cancelado { get; set; }
        public string texto { get; set; }
        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void cmd_cancelarPSQ_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        private void cmd_pesquisarPSQ_Click(object sender, EventArgs e)
        {
            if (textBox_pesquisa.Text == "") return;

            //define o texto e fecha o quadro
            texto = textBox_pesquisa.Text;
            cancelado = false;
            this.Close();
        }

        //keydownERRADO
        private void cmd_pesquisarPSQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                cmd_pesquisarPSQ_Click(cmd_pesquisarPSQ, EventArgs.Empty);
        }

        private void textBox_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                cmd_pesquisarPSQ_Click(cmd_pesquisarPSQ, EventArgs.Empty);
        }
    }
}
