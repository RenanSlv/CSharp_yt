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
using System.Xml.Linq;

namespace ApagarPastasFicheiros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //File.Copy($@"C:\Users\Renan\Documents\config\config.dat", $@"C:\Users\Renan\Documents\config\Test_mudar_arquivo\config.dat");
            //File.Move($@"C:\Users\Renan\Documents\config\config.dat", $@"C:\Users\Renan\Documents\config\Test_mudar_arquivo\config.dat");

            //string[] lista_ficheiros = Directory.GetFiles($@"C:\Users\Renan\Documents\config\" , $@"*.dat");

            //foreach (string item in lista_ficheiros)
            //{
            //    //listBox1.Items.Add(item);
            //    File.Move(item, $@"C:\Users\Renan\Documents\config\Test_mudar_arquivo\" + Path.GetFileName(item));
            //}


            ////File.Delete($@"C:\Users\Renan\Documents\config\config.dat");
            //if(Directory.Exists($@"C:\Users\Renan\Documents\config\Test_mudar_arquivo"))
            //Directory.Delete($@"C:\Users\Renan\Documents\config\Test_mudar_arquivo" ,true);// não pode deletar pasta sem estar vazia, tem que colocar ", true"

            string[] ficheiros = Directory.GetFiles($@"C:\Users\Renan\Documents\config\");

            foreach (string item in ficheiros) 
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(item));
            }
            //listBox1.Items.AddRange(ficheiros);

            MessageBox.Show("Terminado");  
        }
    }
}
