using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_GestorBD gestor = new cl_GestorBD();

            //define as instruções das tabelas
            List<string> instrucoes = new List<string>()
            {
                //tabela clientes
                "CREATE TABLE clientes(",
                "id_cliente     int NOT NULL PRIMARY KEY,",
                "nome           nvarchar(50),",
                "telefone       nvarchar(20),",
                "atualizacao    datetime)",
                "END",

                //tabela compras
                "CREATE TABLE compras(",
                "id_compra      int NOT NULL PRIMARY KEY,",
                "id_cliente     int,",
                "produto        nvarchar(50),",
                "quantidade     int,",
                "preco_unidade  int,",
                "atualizacao    datetime,",
                "FOREIGN KEY(id_cliente) REFERENCES clientes(id_cliente) ON DELETE CASCADE)",
                "END"
            };
            
            gestor.CriarBaseDados($@"C:\Users\Renan\Desktop\CSharp\SQLCEv2\loja2.sdf", instrucoes, true);
        }

        //====================================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            //abertura da base de dados
            cl_GestorBD gestorBD = new cl_GestorBD("loja2.sdf");

            //construção da lista de parâmetros
            List<cl_GestorBD.SQLParametro> parametros = new List<cl_GestorBD.SQLParametro>();
            parametros.Add(new cl_GestorBD.SQLParametro("@item_pesquisa", textBox_pesquisa.Text));
            
            string query = "SELECT * FROM clientes WHERE nome = @item_pesquisa";

            //executa a query
            DataTable dt = gestorBD.EXE_READER(query, parametros);

            //apresenta o numero de linhas devolvidas
            MessageBox.Show(dt.Rows.Count.ToString());
        }

        //====================================================================================
        private void button3_Click(object sender, EventArgs e)
        {
            //abertura da base de dados
            cl_GestorBD gestorBD = new cl_GestorBD("loja2.sdf");

            //construção da lista de parâmetros
            List<cl_GestorBD.SQLParametro> parametros = new List<cl_GestorBD.SQLParametro>();
            
            //executa a query
            DataTable dt = gestorBD.EXE_READER($@"SELECT * FROM clientes WHERE nome = '{textBox_pesquisa.Text}'");

            //apresenta o numero de linhas devolvidas
            MessageBox.Show(dt.Rows.Count.ToString());

        }

        //====================================================================================
        private void button4_Click(object sender, EventArgs e)
        {
            cl_GestorBD gestor = new cl_GestorBD("loja2.sdf");

            //gestorBD.EXE_NON_QUERY($@"INSERT INTO clientes VALUES(
            //                        '{1}', 'Carlos', '111222333', '{DateTime.Now}')");

            List<cl_GestorBD.SQLParametro> parametros = new List<cl_GestorBD.SQLParametro>();
            parametros.Add(new cl_GestorBD.SQLParametro("@id_cliente", 1));
            parametros.Add(new cl_GestorBD.SQLParametro("@nome", "Carlos"));
            parametros.Add(new cl_GestorBD.SQLParametro("@telefone", "111222333"));
            parametros.Add(new cl_GestorBD.SQLParametro("@atualizacao", DateTime.Now));

            gestor.EXE_NON_QUERY($@"INSERT INTO clientes VALUES(
                                    @id_cliente, @nome, @telefone, @atualizacao)"
                                    , parametros);

            MessageBox.Show("OK");

        }

        //====================================================================================
        private void button5_Click(object sender, EventArgs e)
        {
            //verifica se os campos estão preenchidos
            if (textBox_nome.Text == "" || textBox_telefone.Text == "")
            {
                MessageBox.Show("ERRO: Preencha todos os campos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //gravação do novo cliente na base de dados
            cl_GestorBD gestor = new cl_GestorBD("loja2.sdf");

            //gestorBD.EXE_NON_QUERY($@"INSERT INTO clientes VALUES(
            //                        '{1}', 'Carlos', '111222333', '{DateTime.Now}')");

            //busca o id_cliente disponivel
            int id_cliente = gestor.ID_DISPONIVEL("clientes", "id_cliente");

            List<cl_GestorBD.SQLParametro> parametros = new List<cl_GestorBD.SQLParametro>();
            parametros.Add(new cl_GestorBD.SQLParametro("@id_cliente", id_cliente));
            parametros.Add(new cl_GestorBD.SQLParametro("@nome", textBox_nome.Text));
            parametros.Add(new cl_GestorBD.SQLParametro("@telefone", textBox_telefone.Text));
            parametros.Add(new cl_GestorBD.SQLParametro("@atualizacao", DateTime.Now));

            gestor.EXE_NON_QUERY($@"INSERT INTO clientes VALUES(
                                    @id_cliente, @nome, @telefone, @atualizacao)"
                                    , parametros);

            MessageBox.Show("OK");
        }

        //====================================================================================
        private void button6_Click(object sender, EventArgs e)
        {
            //prepara um datatable
            cl_GestorBD gestor = new cl_GestorBD("loja2.sdf");

            DataTable dt = gestor.PREPARAR_DATATABLE("SELECT * FROM clientes");

            foreach (DataRow dr in dt.Rows)
            {
                //alterar o telefone
                string novo_telefone = $@"(01) {dr["telefone"].ToString()}";
                dr["telefone"] = novo_telefone;
            }

            gestor.GRAVAR_DATATABLE(dt);

        }

        //====================================================================================
        private void button7_Click(object sender, EventArgs e)
        {
            //inserir novos clientes na base de dados

            List<String> list_nomes = new List<String>();
            list_nomes.Add("nome 1");
            list_nomes.Add("nome 2");
            list_nomes.Add("nome 3");
            list_nomes.Add("nome 4");
            list_nomes.Add("nome 5");

            List<String> list_telefones = new List<String>();
            list_telefones.Add("778899446");
            list_telefones.Add("444555666");
            list_telefones.Add("987894215");
            list_telefones.Add("752351567");
            list_telefones.Add("324578984");

            cl_GestorBD gestor = new cl_GestorBD("loja2.sdf");
            DataTable dt = gestor.PREPARAR_DATATABLE("SELECT * FROM clientes WHERE id_cliente = -1");

            int id_temp = gestor.ID_DISPONIVEL("clientes", "id_cliente");

            //percorrer todos os nomes e adicionar à datatable
            for (int index = 0; index < list_nomes.Count; index++)
            {
                DataRow nova_linha = dt.NewRow();
                nova_linha["id_cliente"] = id_temp;
                nova_linha["nome"] = list_nomes[index];
                nova_linha["telefone"] = list_telefones[index];
                nova_linha["atualizacao"] = DateTime.Now;
                dt.Rows.Add(nova_linha);
                id_temp++;
            }

            gestor.GRAVAR_DATATABLE(dt);
        }

        //====================================================================================
        private void button8_Click(object sender, EventArgs e)
        {
            //compacta a base de dados
            cl_GestorBD gestor = new cl_GestorBD("loja2.sdf");

            if (gestor.COMPACTAR_BASE_DADOS() == true)
            {
                MessageBox.Show("BD compactada");
            }
            
        }

        //====================================================================================
    }
}
