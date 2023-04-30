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

namespace LigacaoBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ligacao_Click(object sender, EventArgs e)
        {
            // ligação à base de dados
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = $@"Data Source=C:\Users\Renan\Desktop\CSharp\SQLCEv2\teste.sdf";
            ligacao.Open();
            label_resultado.Text = "Ligação realizada com sucesso.";

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("select * from Filmes", ligacao);
            //system.Data
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            ligacao.Close();

            label_resultado.Text = dados.Rows.Count.ToString();
        }
    }
}
