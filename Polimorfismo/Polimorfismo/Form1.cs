using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Polimorfismo";
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            Retangulo forma1 = new Retangulo();
            forma1.Apresentar();
            forma1.Atura = 100;
            forma1.Largura = 50;
            forma1.Desenhar();
            forma1.Desenhar_Outro();

            Triangulo forma2 = new Triangulo();
            forma2.Apresentar();
            forma2.Atura = 150;
            forma2.Largura = 200;
            forma2.Desenhar();
            forma2.Desenhar_Outro();

            Circulo forma3 = new Circulo();
            forma3.Apresentar();
            forma3.Atura = 250;
            forma3.Largura = 300;
            forma3.Desenhar();
            forma3.Desenhar_Outro();
        }
    }
}
