using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//tem que ser acrescentado

namespace FicheirosTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sytem.IO.StreamWriter
            StreamWriter ficheiro = new StreamWriter($@"C:\Users\Renan\Desktop\CSharp\FicheirosTXT\file.txt", true, Encoding.Default);

            //int valor = 100;
            //ficheiro.WriteLine("Primeira frase.");
            //ficheiro.WriteLine("Segunda frase.");
            //ficheiro.WriteLine(valor);

            ficheiro.WriteLine(textBox_msg.Text);
            
            ficheiro.Dispose();//fecha e tirar da memória o ficheiro
            //ficheiro.Close();//fecha o ficheiro mas deixar o gasto de memória

            textBox_msg.Text = "";
            textBox_msg.Focus();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader($@"C:\Users\Renan\Desktop\CSharp\FicheirosTXT\file.txt", Encoding.Default);
            //listBox_lista.Items.Add(ficheiro.ReadLine());
            while (ficheiro.EndOfStream == false) {
                listBox_lista.Items.Add(ficheiro.ReadLine());
            }

            ficheiro.Dispose();
        }
    }
}
