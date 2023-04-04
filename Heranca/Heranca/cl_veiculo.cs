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
        abstract public void Acelerar();// como foi delcarado abstrato tem que ser declarado nas classes herdadas
        
        //virtual pode ser usado e pode ser alterado nas outras classes
        public virtual void Parar() 
        {
            Console.WriteLine("Parou");
        }
    }
}
