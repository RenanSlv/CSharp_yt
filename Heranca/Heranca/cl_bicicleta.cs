using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class cl_bicicleta : cl_veiculo
    {
        public void Pedalar() 
        {
            Console.WriteLine("Pedalou");
        }

        //Foi declarado abstrata na classe principal. Tem que ser implementado
        public override void Acelerar() 
        {
            Console.WriteLine("A bicicleta acelerou");
        }
        public override void Parar()
        {
            Console.WriteLine("A bicicleta parou");
        }

    }
}
