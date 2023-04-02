using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesParametros
{
    class Teste
    {
        public void Executar(int valor) 
        {
            valor++;
        }

        public void Acrescentar5(ref int valor)
        {
            valor += 5;
        }

        public void Diminuir5(ref int valor)
        {
            valor -= 5;
        }

        public int Acrescentar(int valor = 20)
        {
            valor += 10;
            return valor;
        }

        public int Adicionar(int valor, int x = 20) 
        {
            return valor + x;
        }
    }
}
