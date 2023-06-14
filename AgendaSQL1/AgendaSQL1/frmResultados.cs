using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace AgendaSQL1
{
    public partial class frmResultados : Form
    {
        int id_contato;
        string item_pesquisa;
        
        public frmResultados(string item_pesquisa = "")
        {
            InitializeComponent();
            this.item_pesquisa = item_pesquisa;
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            ConstruirTabela();
        }

        private void ConstruirTabela()
        {
            //ligar à BD
            SqlCeConnection conn = new SqlCeConnection("Data source = " + vars.base_dados);
            conn.Open();

            string query = $@"SELECT * FROM contatos";
            if (item_pesquisa != "")
                query = $@"SELECT * FROM contatos WHERE nome LIKE @item OR telefone LIKE @item";

            SqlCeCommand comando = new SqlCeCommand();
            comando.Parameters.AddWithValue("@item", $@"%{item_pesquisa}%");
            comando.CommandText = query;
            comando.Connection = conn;

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
            DataTable dt = new DataTable();
            adaptador.SelectCommand = comando;
            adaptador.Fill(dt);

            data_resultados.DataSource = dt;

            //apresenta o numero de registros na BD
            label_resultados.Text = $@"Resultados = {data_resultados.RowCount}";

            //esconder colunas
            //id_contato e atualização
            data_resultados.Columns[0].Visible = false;
            data_resultados.Columns["atualizacao"].Visible = false;//melhor modo

            //alterar as dimenções das colunas
            data_resultados.Columns["nome"].Width = calcularLargura(65);
            data_resultados.Columns["telefone"].Width = calcularLargura(35);

            //controla a disponibilidade dos comandos
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
            

        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //eliminar a linha selecionada
            SqlCeConnection ligacao = new SqlCeConnection($@"Data Source = " + vars.base_dados);
            ligacao.Open();
            SqlCeCommand comando = new SqlCeCommand($@"DELETE FROM contatos WHERE id_contato = {id_contato}", ligacao);
            comando.ExecuteNonQuery();

            comando.Dispose();
            ligacao.Dispose();

            //reconstruir a tabela de contatos
            ConstruirTabela();

        }

        private void data_resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_contato = Convert.ToInt32(data_resultados.Rows[e.RowIndex].Cells["id_contato"].Value);
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }

        private void cmd_editar_Click(object sender, EventArgs e)
        {
            //editar o registro selecionado
            frmAdicionarEditar frm = new frmAdicionarEditar(id_contato);
            frm.ShowDialog();

            //atualizar a tabela de contatos
            ConstruirTabela();
        }

        private void cmd_vertudo_Click(object sender, EventArgs e)
        {
            //volta a apresentar todos os registros de contatos
            item_pesquisa = "";
            ConstruirTabela();
        }

        //arrumando tamanho das linhas e colunas da tabela
        private int calcularLargura(int percentagem)
        {
            int largura_tabela = data_resultados.Width - 20;
            int resultado = (largura_tabela * percentagem) / 100;
            return resultado;
        }
    }
}
