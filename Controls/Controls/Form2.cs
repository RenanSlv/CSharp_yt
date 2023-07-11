using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form2 : Form
    {
        Form frm;
        public Form2(Form frmativa)
        {
            InitializeComponent();
            frm = frmativa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Controls["label1"].Text = "testando auteração de texto";
            frm.Controls["checkBox1"].Text = "texto checkbox";
            this.Close();


            ListBox lista = (ListBox)frm.Controls["lista1"];
            lista.Items.Add("Frase 1");
            lista.Items.Add("Frase 2");
            lista.Items.Add("Frase 3");

            CheckBox cb = frm.Controls["checkBox1"] as CheckBox;
            cb.Checked = false;
        }
    }
}
