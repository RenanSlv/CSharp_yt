using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace SQLite2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar a base de dados
            //SQLiteConnection.CreateFile($@"C:\SQLiteTest\dados.db");

            //estabelecer a ligação com a base de dados
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = $@"Data Source = C:\SQLiteTest\dados.db; Version = 3";
            conn.Open();

            //criar tabela
            string query = $@"CREATE TABLE contatos(
id_contato int,
nome varchar(50),
telefone varchar(20))";
            SQLiteCommand command = new SQLiteCommand(query,conn);
            command.ExecuteNonQuery();



            MessageBox.Show("OK");
            conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //gravar um registro na base de dados
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = $@"Data Source = C:\SQLiteTest\dados.db; Version = 3";
            conn.Open();

            string query = "INSERT INTO contatos VALUES (0,'João Ribeiro', '123456789')";

            SQLiteCommand cmd = new SQLiteCommand(query,conn);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            conn.Dispose();

            MessageBox.Show("Gravado com sucesso.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = $@"Data Source = C:\SQLiteTest\dados.db; Version = 3";
            conn.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM contatos", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            //apresentar os dados resultantes da query
            foreach (DataRow dr in dt.Rows) 
            {
                listBox_dados.Items.Add(dr["nome"].ToString() + " -> " + dr["telefone"].ToString());
            }

        }
    }
}
