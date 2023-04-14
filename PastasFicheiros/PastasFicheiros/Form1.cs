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

namespace PastasFicheiros
{
    public partial class Form1 : Form
    {

        //string pasta_trabalho = $@"C:\Users\Renan\Desktop\CSharp\PastasFicheiros\trabalho\docs";

        string pasta_config;// = $@"C:\Users\Renan\Desktop\CSharp\PastasFicheiros\config";
        string ficheiro_config = $@"config.dat";


        public Form1()
        {
            InitializeComponent();

            pasta_config = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $@"\config";
            MessageBox.Show(pasta_config);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Determinar se uma pasta existe
            //if (!Directory.Exists(pasta_trabalho))
            //    Directory.CreateDirectory(pasta_trabalho);
            //else
            //    MessageBox.Show("Ela existe");

            //verifica se exite a pasta config se não existir cria.
            gravar_Configuracoes();
            MessageBox.Show("Configurações gravadas com sucesso");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //carregamento das configurações
            if (!File.Exists($@"{pasta_config}\{ficheiro_config}"))
            {
                //MessageBox.Show("Não exite o ficheiro desejado.");
                //return;
                gravar_Configuracoes();

            }

            StreamReader ficheiro = new StreamReader($@"{pasta_config}\{ficheiro_config}", Encoding.Default);
            textBox_nome.Text = ficheiro.ReadLine();
            data_hora.Value = Convert.ToDateTime(ficheiro.ReadLine());
            ficheiro.Dispose();
        }

        private void gravar_Configuracoes() 
        {
            //verifica se a pasta exite. Canão não exita ele cria
            if (!Directory.Exists(pasta_config))
                Directory.CreateDirectory(pasta_config);

            StreamWriter ficheiro = new StreamWriter($@"{pasta_config}\{ficheiro_config}", false, Encoding.Default);
            ficheiro.WriteLine(textBox_nome.Text);
            ficheiro.WriteLine(data_hora.Value.ToShortDateString());
            ficheiro.Dispose();

        }
    }
}
