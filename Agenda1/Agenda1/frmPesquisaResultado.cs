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
    public partial class frmPesquisaResultado : Form
    {
        string texto;
        public frmPesquisaResultado(string texto)
        {
            InitializeComponent();

            //definir o texto de pesquisa
            this.texto = texto.ToUpper();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_novapesquisa_Click(object sender, EventArgs e)
        {
            //pedir novo texto
            frmPesquisa frm = new frmPesquisa();
            frm.ShowDialog();

            if (frm.cancelado) return;

            texto = frm.texto.ToUpper();
            ExecutaPesquisa();
        }

        private void frmPesquisaResultado_Load(object sender, EventArgs e)
        {
            //executa a pesquisa e controi a lista
            ExecutaPesquisa();
        }

        private void ExecutaPesquisa()
        {
            //realiza a pesquisa e apresenta dados
            List<cl_contato> lista_resultados = new List<cl_contato>(); 

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS) 
            {
                if (contato.nome.ToUpper().Contains(texto) || contato.numero.ToUpper().Contains(texto))
                {
                    lista_resultados.Add(contato);
                }
            }

            //listBox_resultadoPSQ.Items.Add(lista_resultados);

            foreach (cl_contato contato in lista_resultados)
                listBox_resultadoPSQ.Items.Add($@"{contato.nome} ({contato.numero})");

            label1.Text = $@"Registros: {listBox_resultadoPSQ.Items.Count}";

        }
    }
}
