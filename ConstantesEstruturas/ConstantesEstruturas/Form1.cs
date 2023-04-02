using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstantesEstruturas
{
    public partial class Form1 : Form
    {
        struct estrutura_pessoa 
        {
            public string Nome;
            public string Sobrenome;
        }
        //const string Nome = "João";
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Nome);
            
            ClassNormal objeto = new ClassNormal();
            Console.WriteLine(objeto.Nome);

            Console.WriteLine(ClassEstatica.Nome);

            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Pessoa 1";
            pessoa1.Sobrenome = "Sobrenome 1";

            estrutura_pessoa pessoa2 = new estrutura_pessoa();
            pessoa2.Nome = "Pessoa 2";
            pessoa2.Sobrenome = "Sobrenome 2";
            Console.WriteLine(pessoa2.Nome + " " + pessoa2.Sobrenome );

            //estrutura_pessoa pessoa2 = new estrutura_pessoa() { Nome = "Pessoa 2", Sobrenome = "Sobrenome 2"}


        }
    }
}
