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
    public partial class frmAdicionarEditar : Form
    {
        int id_contato;
        bool editar;
        public frmAdicionarEditar(int id_contato = -1)
        {
            InitializeComponent();
            this.id_contato = id_contato;

            //definir se vou adicionar ou editar registro
            this.editar = id_contato == -1 ? false : true;
            ////faz a mesma coisa
            //if(id_contato == -1)
            //    editar = false;
            //else
            //    editar = true;


        }

        private void frmAdicionarEditar_Load(object sender, EventArgs e)
        {
            //apresenta o dado do contato, se necessário
            if (this.editar)
                ApresentarContato();
        }

        private void ApresentarContato()
        {
            //apresenta o contato que vai ser editado
            SqlCeConnection conn = new SqlCeConnection($@"Data Source = {vars.base_dados}");
            conn.Open();
            DataTable dados = new DataTable(); 
            SqlCeDataAdapter adapter = new SqlCeDataAdapter($@"SELECT * FROM contatos WHERE id_contato = {id_contato}", conn);
            adapter.Fill(dados);
      
            conn.Dispose();

            //colocar os dados nos textbox
            textBox_nome.Text = dados.Rows[0]["nome"].ToString();
            textBox_telefone.Text = dados.Rows[0]["telefone"].ToString();
        }


        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fecha o quadro GRAVAR/EDITAR
            if(MessageBox.Show("Tem certeza que deseja sair?","SAIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            return;
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection($@"Data Source = " + vars.base_dados);
            conn.Open();
            
            //grava novo registro ou edita registro existente

            #region verificações...

            if (textBox_nome.Text == "" || textBox_telefone.Text == "") {
                MessageBox.Show("Falta preencher todos os campos.");
                return;
            }        

            #endregion


            #region NOVO CONTATO
            if (!this.editar)
            {
                //buscar o id_contato disponível
                DataTable dados = new DataTable();
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter($@"SELECT MAX(id_contato) AS maxid FROM contatos", conn);
                adaptador.Fill(dados);

                //verifica se o valor é nulo
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                {
                    id_contato = 0;
                }
                else 
                {
                    id_contato = Convert.ToInt32(dados.Rows[0][0]) + 1;
                }

                //gravar o novo contato na base de dados
                SqlCeCommand command = new SqlCeCommand();
                command.Connection = conn;
               
                //parametros
                command.Parameters.AddWithValue("@id_contato", id_contato);
                command.Parameters.AddWithValue("@nome", textBox_nome.Text);
                command.Parameters.AddWithValue("@telefone", textBox_telefone.Text);
                command.Parameters.AddWithValue("@atualizacao", DateTime.Now);


                //verifica se já exite um contato com o mesmo nome e telefone
                adaptador = new SqlCeDataAdapter();
                dados = new DataTable();
                command.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND telefone = @telefone";
                adaptador.SelectCommand = command;
                adaptador.Fill(dados);

                if (dados.Rows.Count != 0)
                {
                    //já exite um registro com o mesmo nome e telefone
                    //MessageBox.Show("Já exite um registro com o mesmo nome e telefone.");
                    //return; pode ser usado Enviroment.Newline

                    if (MessageBox.Show($@"Já exite um registro com o mesmo nome e telefone.
Deseja gravar mesmo assim ?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) 
                    {
                        return;
                    }
                }

                

                //texto da query
                command.CommandText = $@"INSERT INTO contatos VALUES(@id_contato,@nome,@telefone,@atualizacao)";
                
                
                
                ////command.CommandText = $@"INSERT INTO contatos VALUES({id_contato},
                ////                     '{textBox_nome.Text}','{textBox_telefone.Text}',
                ////                     '20230518')";  NAO É SEGURO FAZER ASSIM
                command.ExecuteNonQuery();

                command.Dispose();
                conn.Dispose();
                MessageBox.Show("Contato adicionado com sucesso.");

                //limpa campos
                textBox_nome.Text = "";
                textBox_telefone.Text = "";
                textBox_nome.Focus();
            }

            #endregion

            #region EDITAR CONTATO
            else
            {
                //edita o contato na base de dados

                SqlCeCommand command = new SqlCeCommand();
                command.Connection = conn;

                //parametros
                command.Parameters.AddWithValue("@id_contato", id_contato);
                command.Parameters.AddWithValue("@nome", textBox_nome.Text);
                command.Parameters.AddWithValue("@telefone", textBox_telefone.Text);
                command.Parameters.AddWithValue("@atualizacao", DateTime.Now);

                //verifica se existe registro com o mesmo nome e id_contato diferente
                DataTable dt = new DataTable();
                command.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND id_contato <> @id_contato";                    
                SqlCeDataAdapter adapter = new SqlCeDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    //foi encontrado um registro com o mesmo nome e id diferente
                    if (MessageBox.Show($@"Já exite um registro com o mesmo nome.
Deseja gravar ainda assim?", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;


                }

                //editar o registro selecionado
                command.CommandText = $@"UPDATE contatos SET 
nome = @nome,
telefone = @telefone,
atualizacao = @atualizacao
WHERE id_contato = @id_contato";
                command.ExecuteNonQuery();

                this.Close();

            }
            #endregion
        }
    }
}
