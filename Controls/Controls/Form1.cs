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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            label1.Text = checkBox1.Checked.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.CheckedChanged -= new EventHandler(checkBox1_CheckedChanged);
            checkBox1.Checked = true;
            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);

            radioButton1.Checked = true;

            radioButton4.Checked = true;
            panel1.Controls["radioButton4"].Text = "teste";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
