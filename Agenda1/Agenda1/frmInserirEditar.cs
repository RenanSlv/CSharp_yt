using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda1
{
    public partial class frmInserirEditar : Form
    {

        int indice;
        public frmInserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //fechando aba Inserir/Editar
            this.Close();
        }

        private void frmInserirEditar_Load(object sender, EventArgs e)
        {

        }

        private void ConstroiLista() 
        {
            //adiciona à lista de contatos aos contatos registrados
            listBox_dados.Items.Clear();

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                listBox_dados.Items.Add($@"{contato.nome}  ({contato.numero})");
            }

            //atualizar o numero de registros
            label_registros.Text = "Registros: " + listBox_dados.Items.Count;

            //impedir edição e eliminição do registro
            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //insere um novo registro na lista

            //verifica se todos os campos estão preenchidos
            if (textBox_nome.Text == "" || textBox_numero.Text == "") 
            {
                MessageBox.Show("Os campos não estão todos preenchidos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //verifica se exite um registro igual na lista
            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                if (contato.nome == textBox_nome.Text && contato.numero == textBox_numero.Text)
                {
                    MessageBox.Show("Esse registro já exite", "ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //gravar novo registro
            cl_geral.GravarNovoRegistro(textBox_nome.Text, textBox_numero.Text);

            //atualizar a lista de contatos
            ConstroiLista();

            //prepara o quadro para um novo registro
            textBox_nome.Text = "";
            textBox_numero.Text = "";
            textBox_nome.Focus();
        }

        private void listBox_dados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selecionar um contato.
            if (listBox_dados.SelectedIndex == -1) return;

            //seleciona um indice
            indice = listBox_dados.SelectedIndex;
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //apaga o registro selecionado

            //1 eliminar o registro da lista
            cl_geral.LISTA_CONTATOS.RemoveAt(indice);

            //2 renovar o ficheiro
            cl_geral.GravarFicheiro();

            //3 reconstruir a lista de contato
            ConstroiLista();
        }

        private void cmd_editar_Click(object sender, EventArgs e)
        {
            //edita o registro selecionado

            //Coloca no visor o nome e o numero para ser editado
            //textBox_nome.Text = cl_geral.LISTA_CONTATOS[indice].nome;
            //textBox_numero.Text = cl_geral.LISTA_CONTATOS[indice].numero;

            //abre novo formulario apra edicao
            frmEdicao ficheiro = new frmEdicao(indice);
            ficheiro.ShowDialog();

            //altera o numero ou nome na lista


            ////renova o ficheiro
            //cl_geral.GravarFicheiro();

            ////reconstruir a lista
            ConstroiLista();

        }
    }
}
