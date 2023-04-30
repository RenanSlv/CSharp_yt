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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();

            //
            cl_geral.ConstroiListaContatos();


            //apresenta versão do programa
            label_versao.Text = cl_geral.versao;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abre o quadro para gestão dos contatos
            frmInserirEditar formulario = new frmInserirEditar();
            formulario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //abrir o quadro de pesquisa
            frmPesquisa frm = new frmPesquisa();
            frm.ShowDialog();

            //quando fecha o quadro, verifica se foi cancelado
            if (frm.cancelado) return;

            //abrir o quadro com os resultados da pesquisa
            frmPesquisaResultado frm1 = new frmPesquisaResultado(frm.texto);
            frm1.ShowDialog();

        }
    }
}
