using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Emit;

namespace Agenda1
{
    public static class cl_geral
    {
        public static string versao = "v 1.0.0";

        //lista de contatos
        public static List<cl_contato> LISTA_CONTATOS;


        public static void ConstroiListaContatos()
        {

            //método para carregamento da lista de contatos

            //verificar se o ficheiro exite
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + $@"\ficheiro_contatos.txt";

            //cria a lista vazia
            LISTA_CONTATOS = new List<cl_contato>();


            if (!File.Exists(nome_ficheiro))
            {
                //tem que criar o ficheiro
                File.Create("ficheiro_contatos.txt").Close();
            }
            else
            {
                StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);

                while (!ficheiro.EndOfStream)
                {
                    //carrega nome
                    string nome = ficheiro.ReadLine();
                    //carrega numero
                    string numero = ficheiro.ReadLine();

                    //adicionar à lista de contatos o contato carregado
                    cl_contato novo_contato = new cl_contato();
                    novo_contato.nome = nome;
                    novo_contato.numero = numero;

                    LISTA_CONTATOS.Add(novo_contato);
                }

                ficheiro.Dispose();
            }


        }

        public static void GravarNovoRegistro(string _nome, string _numero)
        {
            //gravar um novo registro (na lista e no ficheiro)


            //cl_contato novo = new cl_contato();
            //novo.nome = _nome;
            //novo.numero = _numero;
            //LISTA_CONTATOS.Add(novo);


            //gravar na lista
            LISTA_CONTATOS.Add(new cl_contato() { nome = _nome, numero = _numero });

            //atualiza o ficheiro
            GravarFicheiro();

        }

        public static void GravarFicheiro()
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + $@"\ficheiro_contatos.txt";

            StreamWriter ficheiro = new StreamWriter(nome_ficheiro, false, Encoding.Default);
            foreach (cl_contato contato in LISTA_CONTATOS)
            {
                ficheiro.WriteLine(contato.nome);
                ficheiro.WriteLine(contato.numero);
            }
            ficheiro.Dispose();
        }

        public static void EditaLista(int _indice)
        {

        }
    }
}
