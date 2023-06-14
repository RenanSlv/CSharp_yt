using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLServer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar uma tabela na base de dados SQL Server Express
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = $@"Server = DESKTOP-NJHHBJS\SQLEXPRESS; Database = SQL_TESTES; Trusted_Connection = True";
            conn.Open();

            MessageBox.Show(conn.State.ToString());
            conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //criar a tabela contatos
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = $@"Server = DESKTOP-NJHHBJS\SQLEXPRESS; Database = SQL_TESTES; Trusted_Connection = True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $@"CREATE TABLE contatos(
id_contato  int not null primary key,
nome        varchar(50),
telefone    varchar(20),
atualizacao datetime
)";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Tabela criada com sucesso");
            cmd.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //adicionar um registro a contatos
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = $@"Server = DESKTOP-NJHHBJS\SQLEXPRESS; Database = SQL_TESTES; Trusted_Connection = True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //parametros
            cmd.Parameters.AddWithValue("@id_contato", 1);
            cmd.Parameters.AddWithValue("@nome", "Carlo Miguel");
            cmd.Parameters.AddWithValue("@telefone", "111222333");
            cmd.Parameters.AddWithValue("@atualizacao", DateTime.Now);

            cmd.CommandText = $@"INSERT INTO contatos VALUES(@id_contato,@nome,@telefone,@atualizacao)";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro adicionado com sucesso");
            cmd.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ler registro da base de dados
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = $@"Server = DESKTOP-NJHHBJS\SQLEXPRESS; Database = SQL_TESTES; Trusted_Connection = True";
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM contatos", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows) 
            {
                MessageBox.Show($@"{dr["nome"].ToString()} -> {dr["telefone"].ToString()}");
            }
        }
    }
}
