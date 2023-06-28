using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;
using System.Net.Http.Headers;

namespace Linq
{
    //======================================================================================
    // projeto para testar instruções LINQ em C#
    //======================================================================================
    public partial class frmLINQ : Form
    {  
        List<int> lista_numeros;
        List<string> lista_nomes;
        Dictionary<string, double> lista_produtos;
        List<cl_alunos> lista_alunos;
        DataTable dados;

        public frmLINQ()
        {
            //carrega os dados das coleções
            InitializeComponent();
            cl_colecoes colecoes = new cl_colecoes();
            lista_numeros = colecoes.lista_numeros;
            lista_nomes = colecoes.lista_nomes;
            lista_produtos = colecoes.lista_produtos;
            lista_alunos = colecoes.lista_alunos;
            dados = colecoes.dados;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //apresenta o número de registros em cada coleções
            listBox1.Items.Add($@"lista_numeros = {lista_numeros.Count} números");
            listBox1.Items.Add($@"lista_nomes = {lista_nomes.Count} nomes");
            listBox1.Items.Add($@"lista_produtos = {lista_produtos.Count} produtos");
            listBox1.Items.Add($@"lista_alunos = {lista_alunos.Count} alunos");
            listBox1.Items.Add($@"dados = {dados.Rows.Count}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region EXEMPLO
            //List<string> lista_nomes = new List<string>();
            //lista_nomes.Add("João");
            //lista_nomes.Add("Maria");
            //lista_nomes.Add("Ana");
            //lista_nomes.Add("Marcos");
            //lista_nomes.Add("Isabella");
            //lista_nomes.Add("Hulk");
            //lista_nomes.Add("Tardelli");

            ////foreach (string str in lista_nomes)
            ////{
            ////    listBox1.Items.Add(str);
            ////}

            ////foreach (string str in lista_nomes)
            ////{
            ////    if(str.StartsWith("M"))
            ////        listBox1.Items.Add(str);
            ////}

            ////utilzar o LINQ
            ////var lista_final = lista_nomes.Where(i => i.StartsWith("M")); //Onde cada um dos elementos começa com a letra M
            ////foreach (var item in lista_final) 
            ////{
            ////    listBox1.Items.Add(item);


            ////var final = lista_nome.Were(i => i.StartsWith("M"));  é iGUAL 
            ////var final = from i in lista_nomes
            ////            where i.StartsWith("M")
            ////            select i;


            ////foreach (var str in final)
            ////{
            ////    listBox1.Items.Add(str);
            ////} é igual

            ////listBox1.Items.Add(final.First());


            //List<string> final = (from i in lista_nomes
            //            where i.StartsWith("M")
            //            select i).ToList();

            //for(int x = 0; x < final.Count; x++)
            //    listBox1.Items.Add(final[x]);

            ////string c;
            ////listBox1.Items.Add(final.ForEach());
            ///
            #endregion

            listBox1.Items.Clear();
            label_resultados.Text = "";

            ////execução dos testes de LINQ
            ///1
            //var numeros = from num in lista_numeros
            //              where num <=10 || num >=20
            //              select num;

            //foreach (int n in numeros)
            //    listBox1.Items.Add(n.ToString());

            ////2
            //var nomes = from nome in lista_nomes
            //            where nome.Contains("Gomes") || nome.Contains("Ana")
            //            select nome;

            //foreach (string n in nomes) 
            //{
            //    listBox1.Items.Add(n);
            //}

            ////3.1
            //var resultado = from item in lista_produtos
            //                where item.Key.StartsWith("M")
            //                select item;

            //foreach (KeyValuePair<string,double> res in resultado)
            //{
            //    listBox1.Items.Add(res.Key);// recebe a string
            //    listBox1.Items.Add(res.Value);// recebe o double
            //    listBox1.Items.Add(res);// recebe os 2
            //}

            ////3.2
            ////função lambda
            //var resultado = lista_produtos.Where(produto => produto.Key.StartsWith("M"));

            //foreach (KeyValuePair<string, double> res in resultado)
            //    listBox1.Items.Add(res);

            ////4
            //var resultado = from aluno in lista_alunos
            //                select aluno.nome;

            //foreach (string res in resultado)
            //    listBox1.Items.Add(res);

            ////5.1
            //var resultado = from aluno in lista_alunos
            //                select aluno;

            //foreach (cl_alunos res in resultado)
            //    listBox1.Items.Add($@"O aluno {res.numero} é {res.nome}");

            ////5.2
            //var resultado = from aluno in lista_alunos
            //                select $@"O aluno {aluno.numero} é {aluno.nome}";

            //foreach(string res in resultado)
            //    listBox1.Items.Add(res);

            ////6  mudando a ordem nas lista
            //int[] indices = new int[] { 3, 2, 1 };

            //var resultados = from indice in indices
            //                 select lista_nomes[indice];

            //foreach(string nome in resultados)
            //    listBox1.Items.Add(nome);

            ////7
            //var turma = from a in lista_alunos
            //            select new {num = a.numero, nom = a.nome, sex = a.sexo };

            //foreach(var aluno in turma)
            //    listBox1.Items.Add($@"O aluno de numero {aluno.num} é o {aluno.nom} do sexo {aluno.sex}");

            ////8
            //var turma = from a in lista_alunos
            //            where a.nome.Contains("e")
            //            select a;

            //foreach(var aluno in turma)
            //    listBox1.Items.Add(aluno.nome);

            ////9.1 Ordenação
            //var numeros = from numero in lista_numeros
            //              orderby numero
            //              select numero;

            //foreach (int numero in numeros)
            //    listBox1.Items.Add(numero);

            ////9.2 Ordenação
            //var turma = from aluno in lista_alunos
            //            //where aluno.sexo == "masculino"// ordena só os homens
            //              //orderby aluno.nome.Length // ordena pelo maior nome
            //            orderby aluno.nome descending // descendente
            //              select aluno;

            //foreach (cl_alunos aluno in turma)
            //    listBox1.Items.Add($@"{aluno.nome} = {aluno.nome.Length}");

            ////9.3 Ordenação Lambda
            ////var produtos = from produto in lista_produtos
            ////               orderby produto.Key
            ////               select produto;

            ////lambda
            ////var produtos = lista_produtos.OrderBy(i => i.Key);
            //var produtos = lista_produtos.OrderByDescending(i => i.Key);

            //foreach (KeyValuePair<string, double> produto in produtos)
            //    listBox1.Items.Add(produto.Key);

            ////10.1 Operadores de agregação

            ////label_resultados.Text = lista_numeros.Count().ToString();
            //var contagem = (from numero in lista_numeros
            //               where numero < 20
            //               select numero).Count();

            //var valores = from numero in lista_numeros
            //              where numero < 20
            //              select numero;

            //foreach (var n in valores)
            //    listBox1.Items.Add(n);

            //label_resultados.Text = contagem.ToString();

            ////10.2 Operadores de agregação
            //label_resultados.Text = $@"O somatório dos valore é {lista_numeros.Sum()}";// SOMATORIO

            //label_resultados.Text = lista_numeros.Where(i => i <20).Sum().ToString();// SOMATORIO DOS NUMEROS MENORES QUE 20

            //label_resultados.Text = lista_numeros.Min().ToString();// MOSTRA O MENOR VALOR

            //int resultado = lista_nomes.Min(i => i.Length);
            //label_resultados.Text = $@"O número menor de letras em algum nome {resultado}";

            //double media = lista_numeros.Average();
            //label_resultados.Text = media.ToString();//MEDIA

            ////11.1 OPERADORES DE ELEMENTOS
            //List<int> numeros = new List<int>() { };
            //label_resultados.Text = numeros.FirstOrDefault().ToString();

            //label_resultados.Text = lista_nomes.FirstOrDefault();

            //label_resultados.Text = lista_nomes.ElementAt(2);
            //label_resultados.Text = lista_nomes.Where(i => i.Contains("Silva")).ElementAt(1).ToString();// Seleciona o segundo nome que contem Silva
            //label_resultados.Text = lista_nomes.Where(i => i.Contains("fagundes")).ElementAtOrDefault(0);

            ////12 OUTROS 
            //saber quantos alunos são do sexo masculino
            //int numero_alunos = (from aluno in lista_alunos
            //                    where aluno.sexo == "masculino"
            //                    select aluno).Count();

            //label_resultados.Text = $@"Esta turma tem {numero_alunos} alunos do sexo masculino.";
            //listBox1.Items.Add(string.Format("Esta turma tem {0} alunos do sexo masculino.", numero_alunos));

            //saber os resultados das provas de matemática
            //var notas_matematica = from nota in lista_alunos
            //                       select nota.EXAMES[0];

            //foreach (var nota in notas_matematica)
            //    listBox1.Items.Add($@"{nota.disciplina} = {nota.nota_exame}");

            ////lambda
            ////numero de alunos
            //int numero_alunos = lista_alunos.Where(i => i.sexo == "masculino").Count();
            //label_resultados.Text = numero_alunos.ToString();

            ////restultados de matemática
            //var notas = lista_alunos.Select(i => i.EXAMES[0]);

            //foreach(var nota in notas)
            //    listBox1.Items.Add(nota.nota_exame);

            ////saber quantos alunos tiveram nota acima da média na prova de matemática
            //int aprovados = lista_alunos.Where(i => i.EXAMES[0].nota_exame >= 12).Count();
            //label_resultados.Text = aprovados.ToString();

            //em linQ
            //int aprovados = (from aluno in lista_alunos
            //                where aluno.EXAMES[0].nota_exame >= 12
            //                select aluno).Count();

            //label_resultados.Text = aprovados.ToString();

            //13 OUTROS
            //MEDIA DAS NOTAS
            //double media_matematica = lista_alunos.Average(i => i.EXAMES[0].nota_exame);
            //double media_matematica = (from nota in lista_alunos
            //                          select nota.EXAMES[0].nota_exame).Average();
            //label_resultados.Text = media_matematica.ToString();

            //var notas_biologia = lista_alunos.Select(i => i.EXAMES[2].nota_exame);
            //foreach(var notas in notas_biologia)
            //    listBox1.Items.Add(notas);

            ////calcula a media das notas acima de 12
            //double media_biologia = lista_alunos.Where(i => i.EXAMES[2].nota_exame >= 12).Average(i => i.EXAMES[2].nota_exame);
            //label_resultados.Text = media_biologia.ToString();

            //14 OUTROS DATATABLE
            //foreach (DataRow dr in dados.Rows)
            //{
            //    listBox1.Items.Add($@"id_cliente = {dr["id_cliente"].ToString()} | nome_cliente = {dr["nome_cliente"].ToString()} | cidade = {dr["cidade"].ToString()} | numero_encomendas = {dr["numero_encomenda"].ToString()}");
            //}

            //lista apenas nomes dos clientes
            //var clientes = from cliente in dados.AsEnumerable()
            //               select cliente["nome_cliente"].ToString();

            //foreach(var cliente in clientes)
            //    listBox1.Items.Add(cliente);

            //var clientes = from cliente in dados.AsEnumerable()
            //               select cliente.Field<string>("nome_cliente");

            //var clientes = (from cliente in dados.AsEnumerable()
            //               select cliente.Field<string>("nome_cliente")).OrderBy(i => i);// ordena por ordem alfabetica

            //foreach (var cliente in clientes)
            //    listBox1.Items.Add(cliente);

            //var clientes = (from cliente in dados.AsEnumerable()
            //               select new 
            //               {
            //                   nome = cliente.Field<string>("nome_cliente")
            //               }
            //               ).OrderBy(i => i.nome);

            //foreach (var cliente in clientes)
            //    listBox1.Items.Add(cliente.nome);

            //var clientes = (
            //                from cliente in dados.AsEnumerable()
            //                select new
            //                {
            //                    nome = cliente["nome_cliente"].ToString(),
            //                    numero_encomenda = (int)cliente["numero_encomenda"]
            //                }
            //               ).OrderBy(i => i.numero_encomenda);
            //foreach (var cliente in clientes)
            //{
            //    listBox1.Items.Add($@"O cliente {cliente.nome} tem {cliente.numero_encomenda} encomendas no total");
            //}

            var clientes = from cliente in dados.AsEnumerable()
                           where cliente.Field<string>("cidade") == "Belo Horizonte" 
                           select new
                           {
                               nome = cliente.Field<string>("nome_cliente"),
                               cidade = cliente.Field<string>("cidade")
                           };

            foreach(var cliente in clientes)
                listBox1.Items.Add(cliente.nome + " - " + cliente.cidade);

            //site para pesquisa 101 linq examples

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
