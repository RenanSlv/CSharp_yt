using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoImagem
{
    public class cl_bola
    {
        public int x = 50,
                   y = 50,
                   velocidadeX = 10,
                   velocidadeY = 10;

        public void Mover(int largura, int altura) 
        {
            x += velocidadeX;
            y += velocidadeY;

            //colisões
            //detecta a colisão com o fundo e o topo Y
            if (y + 50 >= altura)
                velocidadeY = -velocidadeY;
            if (y <= 0)
                velocidadeY = -velocidadeY;
            //detecta a colisão com as latereis X
            if (x + 50 >= largura)
                velocidadeX = -velocidadeX;
            if (x <= 0)
                velocidadeX = -velocidadeX;
        }
    }
}
