using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmUm : Form
    {
        string _valor;

        public frmUm(string nome)
        {
            InitializeComponent();

            _valor = nome;
            label_resultado.Text = nome;

            
        }

        private void cmd_1_Click(object sender, EventArgs e)
        {
            //fecha esse formulario
            this.Close();
        }

        private void cmd_2_Click(object sender, EventArgs e)
        {
            label_outra.Text = _valor;
            cmd_2.Text = Geral.Nome; // recebendo de classe estatica
        }

        private void label_outra_Click(object sender, EventArgs e)
        {
            
        }
    }
}
