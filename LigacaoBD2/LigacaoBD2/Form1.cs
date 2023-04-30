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

namespace LigacaoBD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            //ligar
            SqlCeConnection ligacao = new SqlCeConnection($@"Data Source=C:\Users\Renan\Desktop\CSharp\SQLCEv2\teste.sdf");
            //ligacao.ConnectionString = $@"Data Source=C:\Users\Renan\Desktop\CSharp\SQLCEv2\teste.sdf";
            ligacao.Open();


            //recolher dados | executar operações
            DataTable dataTable = new DataTable();
            SqlCeDataAdapter operarioFilmes = new SqlCeDataAdapter("select * from Filmes", ligacao);
            operarioFilmes.Fill(dataTable);


            //fechar 
            ligacao.Close();

            //apresentar resultados

            //Rows = linhas 
            //MessageBox.Show(dataTable.Rows[0]["Diretor"].ToString()); // 1 forma

            //DataRow linha = dataTable.Rows[0];// 2 forma
            //MessageBox.Show(linha["Titulo"].ToString());

            foreach (DataRow row in dataTable.Rows) 
            {
                list_dados.Items.Add(row["Titulo"].ToString() + ", " +
                                     row["Diretor"].ToString()+ ", " +
                                     row["Ano"].ToString());
            }

        }
    }
}
