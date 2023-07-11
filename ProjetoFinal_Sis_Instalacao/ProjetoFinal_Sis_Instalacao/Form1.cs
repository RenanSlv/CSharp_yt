using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_Sis_Instalacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //sair da aplicação
            if (MessageBox.Show("Deseja sair da aplicação ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void cmd_carregar_Click(object sender, EventArgs e)
        {
            //carrega a imagem
            pic_imagem.BackgroundImage = Image.FromFile($@"{Application.StartupPath}/imagens/filhote.jpg");
        }
    }
}
