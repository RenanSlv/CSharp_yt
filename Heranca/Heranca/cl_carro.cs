using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class cl_carro : cl_veiculo
    {
        public int VelocidadeMaxima { get; set; }
        //Foi declarado abstrata na classe principal. Tem que ser implementado
        public override void Acelerar() 
        {
            Console.WriteLine("O carro acelerou");
        }
        //Não precisa ser implementado já que é uma classe virtual
        public override void Parar()
        {
            //executa o que está na classe principal
            base.Parar();
        }
    }
}
