using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Permissoes
{
    public partial class Form1 : Form
    {
        cl_utilizador u1,
                      u2,
                      u3;

        cl_utilizador user;
        public Form1()
        {
            InitializeComponent();

            //definir os utilizadores
            u1 = new cl_utilizador() 
            { utilizador="user1", password="pass1"};

            u2 = new cl_utilizador()
            { utilizador = "user2", password = "pass2", permissoes="1100" };
            
            u3 = new cl_utilizador()
            { utilizador = "user3", password = "pass3", permissoes="0011" };

            //define o utilizador ativo
            user = u2;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Program.VerificarPermissao(user, 0))
                return;

            MessageBox.Show("opção 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Program.VerificarPermissao(user, 1))
                return;
                
            MessageBox.Show("opção 2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Program.VerificarPermissao(user, 2))
                return;
                
            MessageBox.Show("opção 3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Program.VerificarPermissao(user, 3))
                return;
                
            MessageBox.Show("opção 4");
        }
    }
}
