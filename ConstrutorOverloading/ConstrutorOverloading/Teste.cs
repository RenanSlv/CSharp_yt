using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorOverloading
{
    class Teste
    {

        string _nome;
        int _idade;

        //CONSTRUTOR
        public Teste(string nome, int idade) 
        {
            _nome = nome;
            _idade = idade;
        }

        //METODO
        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show($@"{_nome}, {_idade}");
        }

        public void Apresentar(string separador) 
        {
            System.Windows.Forms.MessageBox.Show($@"{_nome}{separador} {_idade}");
        }

        ////ERRO NAO PODE
        //public string Apresentar() 
        //{
        //    return _nome;
        //}

        public void Apresentar(int idade) 
        {
            System.Windows.Forms.MessageBox.Show($@"{_nome}, {idade}");
        }
    }
}
