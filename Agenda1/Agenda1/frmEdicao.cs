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
    public partial class frmEdicao : Form
    {
        int ID; // forma 1 de passar variavel
        private int ind; // forma 2 de passar variavel
        public frmEdicao(int _indice)
        {
            InitializeComponent();
            textBox_nomeEDIT.Text = cl_geral.LISTA_CONTATOS[_indice].nome;
            textBox_numeroEDIT.Text = cl_geral.LISTA_CONTATOS[_indice].numero;

            ID = _indice;
            ind = _indice;
        }

        private void cmd_cancelarEDIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_editarEDIT_Click(object sender, EventArgs e)
        {
                cl_geral.LISTA_CONTATOS[ID].nome = textBox_nomeEDIT.Text;
                cl_geral.LISTA_CONTATOS[ind].numero = textBox_numeroEDIT.Text;

                cl_geral.GravarFicheiro();
                this.Close();
        }
    }
}
