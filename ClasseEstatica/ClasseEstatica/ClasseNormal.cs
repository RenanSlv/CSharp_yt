using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    class ClasseNormal
    {
        public string Nome { get; set; }

        public void ApresentarNome() 
        {
            Console.WriteLine(Nome);
        }
    }
}
