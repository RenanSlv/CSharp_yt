using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //// array
            //string[] nomes;
            //nomes = new string[5];

            //nomes[0] = "João";
            //nomes[1] = "Antônio";
            //nomes[2] = "Carlos";
            //nomes[3] = "Rui";
            //nomes[4] = "Nuno";

            //listBox_resposta.Items.AddRange(nomes);

            // coleção - LIST
            List<string> NOMES = new List<string>();
            NOMES.Add("João");
            NOMES.Add("Antônio");
            NOMES.Add("Carlos");
            NOMES.Add("Rui");
            NOMES.Add("Nuno");
            NOMES.Add("Luisa");
            NOMES.Add("Ana");
            NOMES.Add("Luisa");
            NOMES.Add("Ana");
            NOMES.Add("Luisa");
            NOMES.Add("Ana");


            //foreach (string nome in NOMES) 
            //{
            //    listBox_resposta.Items.Add(nome);
            //}

            //MessageBox.Show(NOMES[4]);

            //MessageBox.Show(NOMES.Count.ToString());

            ////remover
            //NOMES.Remove("Ana");
            //NOMES.RemoveAt(0);

            //if (NOMES.Contains("Ricardo"))
            //    MessageBox.Show("SIM");
            //else
            //    MessageBox.Show("NÂO");

            //foreach (string s in NOMES) 
            //{
            //    listBox_resposta.Items.Add(s);
            //}

            //saber o indice da ultima ocorrencia
            //MessageBox.Show(NOMES.LastIndexOf("Ana").ToString());


        }

        private void cmd_list_inline_Click(object sender, EventArgs e)
        {
            List<int> lista_inteiros = new List<int>() { 10, 20, 30 };
            foreach (int valor in lista_inteiros)
            {
                listBox_resposta.Items.Add(valor);
            }
            
        }

        private void cmd_clear_Click(object sender, EventArgs e)
        {
            listBox_resposta.Items.Clear();
        }

        private void cmd_hashset_Click(object sender, EventArgs e)
        {
            //HashSet não pode existir valores duplicados
            HashSet<string> lista_nomes = new HashSet<string>() 
            {
                "João", "Carlos", "Rui", "Marco"
            };

            //lista_nomes.Add("Nuno");
            ////lista_nomes.Add("marco");

            //if (!lista_nomes.Add("marco"))
            //    MessageBox.Show("Não foi possivel adicionar o nome", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //MessageBox.Show(lista_nomes.Count.ToString());

            foreach (string nome in lista_nomes)
            {
                listBox_resposta.Items.Add(nome);
            }

        }

        private void cmd_dictionary_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> lista_valores = new Dictionary<string, string>();

            //lista_valores.Add("10", "João");
            //lista_valores.Add("115", "Antônio");

            lista_valores.Add("cmd_hashset","Hash Set");
            lista_valores.Add("cmd_list_inline", "List Inline");
            lista_valores.Add("cmd_dictionary","Dictionary");

            //MessageBox.Show(lista_valores["cmd_list_inline"]);

            foreach (KeyValuePair<string,string> valor in lista_valores)
            {
                listBox_resposta.Items.Add(valor.Value);
            }

            if (lista_valores.ContainsKey("cmd_list_inlin"))  
                MessageBox.Show("Exite");
            else
                MessageBox.Show("Não exite");
        }
    }
}
