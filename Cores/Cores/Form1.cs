using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cores
{
    public partial class Form1 : Form
    {
        Color cor = Color.Black;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //caixa.BackColor = Color.FromArgb(155,0,0);
            //alpha é a opaciadade 0->255
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ApresentarCor() 
        {
            cor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            caixa.BackColor = cor;
            label1.Text = $@"RBG = ({trackBar1.Value}, {trackBar2.Value}, {trackBar3.Value})";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_red.Text = $@"Red = {trackBar1.Value.ToString()}";
            ApresentarCor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label_green.Text = $@"Green = {trackBar2.Value.ToString()}";
            ApresentarCor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label_blue.Text = $@"Blue = {trackBar3.Value.ToString()}";
            ApresentarCor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
