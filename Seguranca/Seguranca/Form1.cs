using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguranca
{
    public partial class Form1 : Form
    {
        string codigo = "123abc";
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //verificarção do código introduzido
            if (text_codigo.Text == codigo)
                MessageBox.Show("Correto.");
            else
                MessageBox.Show("Incorreto.");
        }
    }
}
