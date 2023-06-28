using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class cl_alunos 
    {
        public class cl_exames
        {
            public string disciplina { get; set; }
            public int nota_exame { get; set; }
        }

        public int numero { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public List<cl_exames> EXAMES { get; set; }


    }

    public class cl_colecoes
    {
        public List<int> lista_numeros { get; set; }
        public List<string> lista_nomes { get; set; }
        public Dictionary<string, double> lista_produtos { get; set; }
        public List<cl_alunos> lista_alunos { get; set; } 
        public DataTable dados { get; set; }

        public cl_colecoes()
        {
            lista_numeros = new List<int>()
            { 14, 16, 8, 10, 3, 15, 9, 12, 45, 34, 23, 56, 32, 11, 40};

            lista_nomes = new List<string>()
            {"João Ribeiro","Ana Maria","Guilherme Gomes","Rafaela Reis","Arthur Gomes",
            "Renata Silva","Renan Silva","Jadel Goleador","Isabela Aparecida","Hulk Galodoido",};

            lista_produtos = new Dictionary<string, double>()
            {
                { "Laranja", 12.5 },
                { "Maça", 8.7},
                { "Ananás", 17.2},
                { "Maracujá", 4.6},
                { "Banana", 2.8},
                { "Pão", 1.2},
                { "Sorvete", 8},
                { "Refrigerante", 18.5},
                { "Queijo", 32.2},
                { "Arroz", 12.4}
            };

            lista_alunos = new List<cl_alunos>();
            cl_alunos aluno;

            //aluno 1
            aluno = new cl_alunos();
            aluno.numero = 1;
            aluno.nome = "Ana Carolina";
            aluno.sexo = "feminino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 12},
                new cl_alunos.cl_exames() { disciplina = "Ingês", nota_exame = 14},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 9},
                new cl_alunos.cl_exames() { disciplina = "Física", nota_exame = 11 }
            };
            lista_alunos.Add(aluno);

            //aluno 2
            aluno = new cl_alunos();
            aluno.numero = 2;
            aluno.nome = "Joaquim Ferreira";
            aluno.sexo = "masculino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 15},
                new cl_alunos.cl_exames() { disciplina = "Ingês", nota_exame = 10},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 8},
                new cl_alunos.cl_exames() { disciplina = "Física", nota_exame = 18 }
            };
            lista_alunos.Add(aluno);

            //aluno 3
            aluno = new cl_alunos();
            aluno.numero = 3;
            aluno.nome = "Beatriz Alves";
            aluno.sexo = "feminino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 7},
                new cl_alunos.cl_exames() { disciplina = "Ingês", nota_exame = 17},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 19},
                new cl_alunos.cl_exames() { disciplina = "Física", nota_exame = 14 }
            };
            lista_alunos.Add(aluno);

            //aluno 4
            aluno = new cl_alunos();
            aluno.numero = 4;
            aluno.nome = "Hulk Goleador";
            aluno.sexo = "masculino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 20},
                new cl_alunos.cl_exames() { disciplina = "Ingês", nota_exame = 20},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 20},
                new cl_alunos.cl_exames() { disciplina = "Física", nota_exame = 20 }
            };
            lista_alunos.Add(aluno);

            //aluno 5
            aluno = new cl_alunos();
            aluno.numero = 5;
            aluno.nome = "Ana Maria";
            aluno.sexo = "feminino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 5},
                new cl_alunos.cl_exames() { disciplina = "Ingês", nota_exame = 8},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 9},
                new cl_alunos.cl_exames() { disciplina = "Física", nota_exame = 4 }
            };
            lista_alunos.Add(aluno);

            //aluno 6
            aluno = new cl_alunos();
            aluno.numero = 6;
            aluno.nome = "João Abreu";
            aluno.sexo = "masculino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 15},
                new cl_alunos.cl_exames() { disciplina = "Ingês", nota_exame = 14},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 17},
                new cl_alunos.cl_exames() { disciplina = "Física", nota_exame = 11 }
            };
            lista_alunos.Add(aluno);

            //aluno 7
            aluno = new cl_alunos();
            aluno.numero = 7;
            aluno.nome = "Ursula Silva";
            aluno.sexo = "feminino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 16},
                new cl_alunos.cl_exames() { disciplina = "Ingês", nota_exame = 16},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 5},
                new cl_alunos.cl_exames() { disciplina = "Física", nota_exame = 11 }
            };
            lista_alunos.Add(aluno);

            //aluno 8
            aluno = new cl_alunos();
            aluno.numero = 8;
            aluno.nome = "Hugo Soares";
            aluno.sexo = "masculino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 14},
                new cl_alunos.cl_exames() { disciplina = "Ingês", nota_exame = 4},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 11},
                new cl_alunos.cl_exames() { disciplina = "Física", nota_exame = 9 }
            };
            lista_alunos.Add(aluno);

            //aluno 9
            aluno = new cl_alunos();
            aluno.numero = 9;
            aluno.nome = "Ana Amelia";
            aluno.sexo = "feminino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 12},
                new cl_alunos.cl_exames() { disciplina = "Ingês", nota_exame = 14},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 14},
                new cl_alunos.cl_exames() { disciplina = "Física", nota_exame = 12 }
            };
            lista_alunos.Add(aluno);

            //aluno 10
            aluno = new cl_alunos();
            aluno.numero = 10;
            aluno.nome = "Renan Silva";
            aluno.sexo = "masculino";
            aluno.EXAMES = new List<cl_alunos.cl_exames>()
            {
                new cl_alunos.cl_exames() { disciplina = "Matemática", nota_exame = 18},
                new cl_alunos.cl_exames() { disciplina = "Ingês", nota_exame = 18},
                new cl_alunos.cl_exames() { disciplina = "Biologia", nota_exame = 19},
                new cl_alunos.cl_exames() { disciplina = "Física", nota_exame = 17}
            };
            lista_alunos.Add(aluno);


            dados = new DataTable();
            dados.Columns.Add("id_cliente", typeof(int));
            dados.Columns.Add("nome_cliente", typeof(string));
            dados.Columns.Add("cidade", typeof(string));
            dados.Columns.Add("numero_encomenda", typeof(int));

            //carrega os dados de todos os clientes
            StreamReader file = new StreamReader(Environment.CurrentDirectory + @"\dados.txt");
            while (!file.EndOfStream)
            {
                DataRow linha = dados.NewRow();
                linha["id_cliente"] = int.Parse(file.ReadLine());
                linha["nome_cliente"] = file.ReadLine();
                linha["cidade"] = file.ReadLine();
                linha["numero_encomenda"] = int.Parse(file.ReadLine());
                dados.Rows.Add(linha);   
            }
            file.Dispose();

        }
    }
}
