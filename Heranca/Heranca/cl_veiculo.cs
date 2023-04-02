using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    abstract class cl_veiculo
    {
        public string Marca { get; set; }
        public string Cor { get; set; }
        public void Acelerar() 
        {
            Console.WriteLine("Acelerou");
        }
    }
}
