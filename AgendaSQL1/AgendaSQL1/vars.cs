using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlServerCe;

namespace AgendaSQL1
{
    public static partial class vars
    {
        public static string versao = "v.1.0.0";
        public static string pasta_dados;
        public static string base_dados;

        //Inicia aplicação
        public static void Iniciar()
        {
            pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $@"\AgendaSQL\";

            //Verifica a existencia da pasta, caso não exista cria
            if(!Directory.Exists(pasta_dados))
                Directory.CreateDirectory(pasta_dados);
            
            //Verifica se a base de dados existe
            base_dados = pasta_dados + $@"dados.sdf; Password = '123456'";
            if(!File.Exists(pasta_dados + $@"dados.sdf"))
                CriarBaseDados();
            
            
        }

        public static void CriarBaseDados() 
        {
            //Cria base de dados
            SqlCeEngine motor = new SqlCeEngine($@"Data Source = " + base_dados);
            motor.CreateDatabase();

            //Criar estrutura de dados
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = $@"Data Source = " + base_dados;
            ligacao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = 
                $@"CREATE TABLE contatos(
                    id_contato  INT NOT NULL PRIMARY KEY,
                    nome NVARCHAR(50),
                    telefone NVARCHAR(20),
                    atualizacao DATETIME
                )";
            comando.Connection = ligacao;
            comando.ExecuteNonQuery();

            comando.Dispose();//tirar da memoria
            ligacao.Dispose();//tirar da memoria

        }


        

    }
}
