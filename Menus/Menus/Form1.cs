using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_open.Enabled = false;
        }

        private void menu_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open");
        }

        private void menu_combobox_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menu_combobox.Items.Add("Valor1");
            menu_combobox.Items.Add("Valor2");
            menu_combobox.Items.Add("Valor3");
        }

        private void menu_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu_combobox.Text == "Valor1")
                MessageBox.Show("VALOR 1");

            label_resultado.Text = menu_combobox.Text;
            
        }
    }
}
