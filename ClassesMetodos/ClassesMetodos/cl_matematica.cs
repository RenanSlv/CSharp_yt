using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodos
{
    class cl_matematica
    {
        //AULA 1
        ////##############################################################
        //public int Adicao(int numero1, int numero2) 
        //{
        //    return numero1 + numero2;
        //}

        ////##############################################################
        //public int Subtracao(int numero1, int numero2)
        //{
        //    return numero1 - numero2;
        //}

        ////##############################################################
        //public int Multiplicacao(int numero1, int numero2) 
        //{
        //    return numero1 * numero2;
        //}

        ////##############################################################
        //public int Divisao(int numero1, int numero2) 
        //{
        //    return numero1 / numero2;
        //}

        int numero1, numero2;
                        
        public int Operacoes(int numero1, int numero2, string operador) 
        {
            int resultado;
            //switch (operador) 
            //{
            //    case "+":
            //        resultado = numero1 + numero2;
            //        break;
            //    case "-":
            //        resultado = numero1 - numero2;
            //        break;
            //    case "*":
            //        resultado = numero1 * numero2;
            //        break;
            //    case "/":
            //        resultado = numero1 / numero2;
            //        break;
            //    default:
            //        resultado = -1; 
            //        break;
            //}

            this.numero1 = numero1;
            this.numero2 = numero2;
            switch (operador)
            {
                case "+":
                    resultado = Adicao();
                    break;
                case "-":
                    resultado = Subtracao();
                    break;
                case "*":
                    resultado = Multiplicacao();
                    break;
                case "/":
                    resultado = Divisao();
                    break;
                default:
                    resultado = -1;
                    break;
            }

            return resultado;
        }

        private int Adicao()
        {
            return numero1 + numero2;
        }

        private int Subtracao()
        {
            return numero1 - numero2;
        }

        private int Multiplicacao() 
        {
            return numero1 * numero2;
        }

        private int Divisao() 
        {
            return numero1 / numero2;
        }

    }
}
