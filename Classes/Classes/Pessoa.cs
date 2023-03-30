using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Pessoa
    {
        //AULA 1
        //public string nome;
        //public int idade;
        //public string cor_cabelo;
        //public int altura;

        //public void Falar() 
        //{
        //    System.Windows.Forms.MessageBox.Show($@"Olá o meu nome é {nome}");
        //}

        //public void Apresentar_se() 
        //{
        //    System.Windows.Forms.MessageBox.Show($@"Olá meu nome é {nome} e tenho {idade} anos");
        //}

        //AULA 2
        public string nome;
        public string apelido;
        public void Falar1() 
        {
            System.Windows.Forms.MessageBox.Show("Falar.");
        }

        public void Correr() 
        {
            System.Windows.Forms.MessageBox.Show("Correr");
            Saltar();
        }

        private void Saltar()
        {
            System.Windows.Forms.MessageBox.Show("Saltar");
        }

        public void IdentificarSe()
        {
            System.Windows.Forms.MessageBox.Show(ConstruirNome());
        }

        private string ConstruirNome()
        {
            string nomeCompleto = nome + " " + apelido; 
           return nomeCompleto;
        }
    }
}
