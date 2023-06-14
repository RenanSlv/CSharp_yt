using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Data;

//============================================================================================
// classe que permite gerir bases de dados
// versão 1.0.0
//============================================================================================

namespace GestorBD
{
    public class cl_GestorBD
    {
        SqlCeConnection conn;
        SqlCeCommand cmd;
        SqlCeDataAdapter adapter;

        string strConn = "";
        string pasta_bd = $@"C:\Users\Renan\Desktop\CSharp\SQLCEv2\";
        string bd_password = "123456";

        SqlCeDataAdapter adapter_temp;

        //cria a classe de paramentros SQL
        public class SQLParametro
        {
            public string parametro { get; set; }
            public object valor { get; set; }
            public SQLParametro(string parametro, object valor)
            {
                this.parametro = parametro;
                this.valor = valor;
            }
        }
                

        //====================================================================================
        public cl_GestorBD() 
        {
        }

        //====================================================================================
        public cl_GestorBD(string base_dados) 
        {
            //definir a connectionstring da ligação
            //strConn = $@"Data souce = {pasta_bd + base_dados}.sdf; Password = {bd_password}";
            StringBuilder sb = new StringBuilder();
            
            //define a bse da strConn
            sb.Append($@"Data source = ");
            
            //se exite pasta/localização definida...
            if(pasta_bd != "")
                sb.Append(pasta_bd);

            //acrescente o nome do ficheiro da base de dados
            sb.Append(base_dados);

            //adiciona um password se for necessário
            if(bd_password != "")
                sb.Append("; Password = " + bd_password);

            //define finalmente a strConn
            strConn = sb.ToString();

            //temp
            conn = new SqlCeConnection(strConn);
            conn.Open();
            

        }

        //====================================================================================
        public void CriarBaseDados(string base_dados, List<string> instrucoes, bool verificar_pasta = false)
        {
            #region Criação da base de dados
            //criar uma base de dados nova
            #region verificação da exitência de ficheiro de base de dados
            if (verificar_pasta)
            {
                //executa a verificação
                if (File.Exists(base_dados)) {
                    if (MessageBox.Show($@"Exite uma base de dados com o mesmo nome.
Deseja substituir a base de dados exitente?", "ATENÇÂO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        //apagar o ficheiro existente
                        try
                        {
                            File.Delete(base_dados);
                            int a = 0;
                        }
                        catch 
                        {
                            MessageBox.Show("Aconteceu um erro ao eliminar a base de dados.");
                            return;
                        }
                    }
                }
            }
            #endregion

            //construção da connectionstring
            StringBuilder sb = new StringBuilder();
            sb.Append("Data source = ");

            //pasta de destino
            if (pasta_bd != "")
                sb.Append(pasta_bd);

            //nome da base de dados
            sb.Append(base_dados);

            //verifica se tem password
            if (bd_password != "")
                sb.Append($@"; Password = {bd_password};");

            //criação da base de dados
            SqlCeEngine motor = new SqlCeEngine(sb.ToString());
            motor.CreateDatabase();
            #endregion

            #region Criação das tabelas
            //--------------------------------------------------------------------------
            //criação das tabelas dentro da base de dados
            conn = new SqlCeConnection(sb.ToString());
            conn.Open();
            cmd = new SqlCeCommand();
            cmd.Connection = conn;

            //executa as instruções para criar as tabelas
            sb = null;
            foreach (string item in instrucoes)
            {
                if (item.StartsWith("CREATE TABLE"))
                {
                    //inicia a construção da query
                    sb = new StringBuilder();
                    sb.Append(item);
                }
                else if (item == "END")
                {
                    //fechar a criação da query e executa
                    cmd.CommandText = sb.ToString();
                    cmd.ExecuteNonQuery();
                }
                else 
                {
                    //adicionar contato ao stringbuilder
                    sb.Append(item);
                }
            }

            //fecha o comando e a ligação
            cmd.Dispose();
            conn.Dispose();
            #endregion

        }

        //====================================================================================
        public DataTable EXE_READER(string query, List<SQLParametro> parametros = null)
        {
            //ler ou pesquisar informações da base de dados
            //SELECT

            DataTable dados = new DataTable();

            adapter = new SqlCeDataAdapter(query, strConn);
            adapter.SelectCommand.Parameters.Clear();

            //executar a query
            try 
            {
                // inserir os parâmetros na query
                if (parametros != null) 
                {
                    foreach (SQLParametro p in parametros) 
                        adapter.SelectCommand.Parameters.AddWithValue(p.parametro, p.valor);
                }
                adapter.Fill(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"ERRO: {ex.Message}");
            }

            adapter.Dispose();
            return dados;
        }

        //====================================================================================
        public void EXE_NON_QUERY(string query, List<SQLParametro> parametros = null) 
        {
            //executar queries do tipo INSERT, DELETE, UPDATE, CREATE TABLE, etc.
            conn = new SqlCeConnection(strConn);
            conn.Open();
            cmd = new SqlCeCommand(query, conn);
            cmd.Parameters.Clear();

            try
            {
                //adição de parâmetros no comando
                if (parametros != null)
                {
                    foreach (SQLParametro p in parametros) 
                    {
                        cmd.Parameters.AddWithValue(p.parametro, p.valor);
                    }

                    //executar a query
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"ERROR: {ex.Message} ");
                throw;
            }

            
            //"desligando"
            cmd.Dispose();
            conn.Dispose();
        }

        //====================================================================================
        public int ID_DISPONIVEL(string tabela, string coluna)
        {
            //devolve o ID disponível para o próximo registro
            int idtemp = -1;

            string query = $@"SELECT MAX({coluna}) AS MaxID FROM {tabela}";

            DataTable dt = new DataTable();
            adapter = new SqlCeDataAdapter(query, strConn);
            adapter.Fill(dt);

            //verifica se é DBNull ou não
            if (dt.Rows.Count != 0)
            {
                if (DBNull.Value.Equals(dt.Rows[0][0]))
                    idtemp = 0;
                else
                    idtemp = Convert.ToInt32(dt.Rows[0][0]) + 1;
            }

            return idtemp;
        }

        //====================================================================================
        // 1. preparar uma datatable
        public DataTable PREPARAR_DATATABLE(string query)
        {
            //preparar a datatable para atualização ou inserção de dados
            adapter_temp = new SqlCeDataAdapter(query, strConn);
            DataTable dt = new DataTable();

            try
            {
                adapter_temp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"ERRO: {ex.Message}");
                throw;
            }

            return dt;
        }

        //====================================================================================
        // 2. atualizar a base de dados com os novos dados
        public void GRAVAR_DATATABLE(DataTable dt) 
        {
            //atualiza a informação na base de dados
            SqlCeCommandBuilder cmd = new SqlCeCommandBuilder(adapter_temp);
            adapter_temp.UpdateCommand = cmd.GetUpdateCommand();

            try
            {
                adapter_temp.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"ERRO: {ex.Message}");
                throw;
            }

            adapter_temp.Dispose();
        }

        //====================================================================================
        public bool COMPACTAR_BASE_DADOS()
        {
            //compacta a base de dados
            bool concluido = false;

            try
            {
                SqlCeEngine motor = new SqlCeEngine();
                motor.LocalConnectionString = strConn;
                motor.Compact(strConn);
                concluido = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return concluido;
        }
    }
}
