using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseEstatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = ClasseEstatica.NomePrograma;
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            ClasseNormal objeto1 = new ClasseNormal();
            objeto1.Nome = "Joaquim";
            objeto1.ApresentarNome();

            ClasseNormal objeto2 = new ClasseNormal();
            objeto2.Nome = "João";
            objeto2.ApresentarNome();



            ClasseEstatica.Nome = "Renan";
            ClasseEstatica.ApresentarNome();
            ClasseEstatica.Nome = "Marcelo";
            ClasseEstatica.ApresentarNome();
        }
    }
}
