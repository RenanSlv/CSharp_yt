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
using System.Data.SqlClient;

namespace LigacaoBD3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            //buscar todos os dados da tabela
            try
            {
                SqlCeConnection ligacao = new SqlCeConnection($@"Data Source=C:\Users\Renan\Desktop\CSharp\SQLCEv2\dados.sdf");
                ligacao.Open();

                DataTable dt = new DataTable();
                SqlCeDataAdapter operario = new SqlCeDataAdapter("select * from Pessoas", ligacao);
                //operario.SelectCommand.CommandText = "select * from Pessoas";
                operario.Fill(dt);

                ligacao.Close();

                list_dados.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    list_dados.Items.Add(dr["nome"].ToString() + " - " +
                                         dr["endereco"].ToString() + " - " +
                                         dr["telefone"].ToString());
                }
            }
            catch
            {
                MessageBox.Show("ERRO!");
            }


        }

        private void cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                //inserir um novo registro na base de dados
                SqlCeConnection ligacao = new SqlCeConnection();
                ligacao.ConnectionString = $@"Data Source=C:\Users\Renan\Desktop\CSharp\SQLCEv2\dados.sdf";
                ligacao.Open();

                string query = "insert into Pessoas values('Fabio Alexandre', 'Rua das Oportunidades', '798465000')";

                SqlCeCommand operario = new SqlCeCommand(query, ligacao);
                operario.ExecuteNonQuery();

                ligacao.Close();
            }
            catch
            {
                MessageBox.Show("Aconteceu um erro !!!");
            }
        }

        private void cmd_update_Click(object sender, EventArgs e)
        {
            //atualizar dados na base de dados
            try
            {
                //ligar/conectar BD
                SqlCeConnection conn = new SqlCeConnection();
                conn.ConnectionString = $@"Data Source = C:\Users\Renan\Desktop\CSharp\SQLCEv2\dados.sdf";
                conn.Open();

                string query = $@"UPDATE Pessoas SET nome='Nome Editado' WHERE nome='Rui Daniel'";
                string query1 = $@"UPDATE Pessoas SET endereco='Rua mais recente', telefone='111222444' WHERE nome='Nome Editado'";

                //atualização de um registro
                SqlCeCommand operario = new SqlCeCommand(query, conn);
                //operario.CommandText = "update Pessoas set nome='Nome Editado' where nome='Rui Daniel'";
                operario.CommandText = query1;
                operario.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Aconteceu um erro na Edição !!!");
            }
        }

        private void cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //ligar/conectar
                SqlCeConnection conn = new SqlCeConnection($@"Data Source=C:\Users\Renan\Desktop\CSharp\SQLCEv2\dados.sdf");
                conn.Open();

                //eliminição de dados
                string query = "DELETE FROM Pessoas WHERE nome = 'João Ribeiro'";
                SqlCeCommand cmd = new SqlCeCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                

                //fechar
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao deletar um dado.");
            }
        }
    }
}
