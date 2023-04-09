using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            label1.Text = "Novo texto";
            label1.BackColor = Color.Red;
            label1.Width = 300;
            label1.Height = 100;
            label1.Size = new Size(250,150);

            if (checkBox1.Checked)
                label1.Text = "Checked";
            else
                label1.Text = "Unchecked";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmd_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked) 
            //    label1.Visible = true;
            //else 
            //    label1.Visible = false;

            label1.Visible = checkBox1.Checked;
        }
    }
}
