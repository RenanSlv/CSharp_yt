using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            ////AULA 1
            //string nome = "João";
            //Pessoa pessoa1 = new Pessoa();

            //pessoa1.nome = "Teste 1";
            //pessoa1.idade = 40;
            //pessoa1.cor_cabelo = "Preto";
            //pessoa1.altura = 180;

            //Pessoa pessoa2 = new Pessoa();

            //pessoa2.nome = "Teste 2";
            //pessoa2.idade = 35;
            //pessoa2.cor_cabelo = "Amarelo";
            //pessoa2.altura = 175;

            //label_txt.Text = pessoa1.nome;
            //pessoa1.Apresentar_se();
            //label_txt.Text = pessoa2.nome;
            //pessoa2.Apresentar_se();

            //AULA 2
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "João";
            pessoa.apelido = "Ribeiro";
            pessoa.Falar1();
            pessoa.Correr();

            pessoa.IdentificarSe();

        }
    }
}
