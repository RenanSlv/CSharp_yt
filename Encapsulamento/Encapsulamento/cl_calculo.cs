using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class cl_calculo
    {
        private int _percentagem1 = 5;
        private int _percentagem2 = 12;
        private int _percentagem3 = 23;

        public int CalcularPrecoFinal(int precoInicial, int tipoProduto) 
        {
            int precoFinal;
            switch (tipoProduto)
            {
                case 1:
                    precoFinal = precoInicial + ((precoInicial * _percentagem1) / 100);
                    break;
                case 2:
                    precoFinal = precoInicial + ((precoInicial * _percentagem2) / 100);
                    break;
                case 3:
                    precoFinal = precoInicial + ((precoInicial * _percentagem3) / 100) ;
                    break;
                default:
                    precoFinal = -1;
                    break;
            }
            return precoFinal;
        }

    }
}
