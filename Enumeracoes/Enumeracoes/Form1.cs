using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumeracoes
{
    public partial class Form1 : Form
    {
        Teste jogador;
        public Form1()
        {
            InitializeComponent();

            jogador = new Teste();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //Teste objeto = new Teste();
            ////objeto.ApresentarDia(Teste.DiasDaSemana.terça);
            //objeto.Mover(Teste.Movimentos.Direita);
        }

        private void cmd_cima_Click(object sender, EventArgs e)
        {
            //Move-se para cima
            jogador.Mover(Teste.Movimentos.Cima);

        }

        private void cmd_esquerda_Click(object sender, EventArgs e)
        {
            //Move-se para esquerda
            jogador.Mover(Teste.Movimentos.Esquerda);
        }

        private void cmd_direita_Click(object sender, EventArgs e)
        {
            //Move-se para direita
            jogador.Mover(Teste.Movimentos.Direita);
        }

        private void cmd_baixo_Click(object sender, EventArgs e)
        {
            //Move-se para baixo
            jogador.Mover(Teste.Movimentos.Baixo);
        }
    }
}
