using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JustTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ficheiro = $@"C:\Users\Renan\Desktop\CSharp\JustTests\PASTATESTE";
            //ficheiro = Path.ChangeExtension(ficheiro, ".txt");

            if (!Directory.Exists(ficheiro))
                Directory.CreateDirectory(ficheiro);
        }
    }
}
