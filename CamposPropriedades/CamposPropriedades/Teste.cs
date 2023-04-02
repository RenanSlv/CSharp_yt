using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposPropriedades
{
    class Teste
    {

        //definição de um CAMPO
        private string _nome;
        int _idade;
        
        //definição de uma PROPRIEDADE
        public string Nome 
        {
            set
            {
                if (value == "João")
                {
                    System.Windows.Forms.MessageBox.Show("Aconteceu um ERRO!");
                    _nome = "Não pode";
                }
                else
                    _nome = value;
            }
            get 
            {
                return _nome;
            }
        }

        public int Idade { get { return _idade; } set { _idade = value; }}

        public string Apelido { get; set; }

        public void Apresentar() 
        {
            System.Windows.Forms.MessageBox.Show($@"Nome : {_nome}
Idade : {_idade}
Apelido : {Apelido}");
        }

    }
}
