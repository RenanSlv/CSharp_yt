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
    }
}
