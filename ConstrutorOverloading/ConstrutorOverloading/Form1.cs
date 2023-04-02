using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstrutorOverloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            Teste v = new Teste("João", 40);
            int valor = 35;
            MessageBox.Show($@"{10}, {valor} ");
            v.Apresentar();
            v.Apresentar("/ ");
            v.Apresentar("<><><><><><><><><<><>");
            v.Apresentar(35);
            v.Apresentar(25);
            
        }
    }
}
