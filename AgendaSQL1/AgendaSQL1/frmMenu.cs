using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace AgendaSQL1
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
            label_versao.Text = vars.versao.ToString();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicação ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Application.Exit();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void cmd_adicionar_Click(object sender, EventArgs e)
        {
            //Mostra os registros na agenda
            frmAdicionarEditar frm = new frmAdicionarEditar();
            frm.ShowDialog();

        }

        private void label_titulo_Click(object sender, EventArgs e)
        {

        }

        private void cmd_visualizar_Click(object sender, EventArgs e)
        {
            //abrir um quadro para apresentação de todos os resultados
            frmResultados frm = new frmResultados();
            frm.ShowDialog();
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //abrir o quadro para iniciar a pesquisa de um contato
            frmPesquisa frm = new frmPesquisa();
            frm.ShowDialog();

            //executa a pesquisa, se o quadro não foi cancelado
            if (frm.cancelado)
            {
                frm.Dispose();
                return;
            } 

            //executar a pesquisa, se o quadro não foi cancelado
            frmResultados f = new frmResultados(frm.texto_pesquisa);
            f.ShowDialog();


        }

        private void cmd_reset_Click(object sender, EventArgs e)
        {
            //Apaga todos os registros da base de dados
            if (MessageBox.Show("Deseja apagar todos os registros da base de dados?", "ATENÇÂO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            //eliminina todos os registros da base de dados
            SqlCeConnection conn = new SqlCeConnection($@"Data Source = {vars.base_dados}");
            conn.Open();

            SqlCeCommand command = new SqlCeCommand("DELETE FROM contatos", conn);
            command.ExecuteNonQuery();
            conn.Dispose();

            //mensagem que informa que todos os contatos foram eliminados
            MessageBox.Show("Todos os dados foram deletados.");
        }
    }
}
