using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Strings
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
            //STRINGS

            string frase = "Este tipo de variável é alfanúmerico.";

            //label_txt.Text = frase + "(contém " + frase.Length + " letras.)";//quantidade de letras e espaços
            //label_txt.Text = frase.ToUpper();//deixar todas as letras em maiusculo.
            //label_txt.Text = frase.Substring(5,4);//quebrar string (inicio, quantidade apos o inicio)

            //bool resultado = frase.Contains("é");//verifica se a string esta na string
            //label_txt.Text = resultado.ToString();

            //bool resultado1 = frase.EndsWith(".");
            //label_txt.Text = resultado1.ToString();

            //label_txt.Text = ">" + frase.Trim() + "<";// retira espaços do começo e final da string

            //int x = frase.LastIndexOf("e");

            //label_txt.Text = x.ToString(); // verifica a ocorrencia (posição)
            //string adiciona = "TEST ADD ";
            //string fraseAdicional = frase.Insert(5, adiciona);// adiciona frase na string
            //label_txt.Text = fraseAdicional;

            //string final = frase.Replace('e','_');
            //label_txt.Text = final;

            string items = "joão,paulo,carlos,manuel,antónio";
            string[] nomes = items.Split(',');// separar string

            foreach(string n in nomes)
            {
                label_txt.Text = n;
            }
        }
    }
}
