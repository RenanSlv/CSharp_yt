using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioRetorno
{
    public partial class frm2 : Form
    {

        public string _nome { get; set; }
        public frm2(string nome)
        {
            InitializeComponent();

            textBox_nome.Text = nome;
        }

        private void frm2_Load(object sender, EventArgs e)
        {

        }

        private void cmd_ok_Click(object sender, EventArgs e)
        {
            //definir o valor a retornar
            _nome = textBox_nome.Text;
            if(textBox_nome.Text == "")
                _nome = null;
            else
                _nome = textBox_nome.Text;
            this.Close();
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            //fechar o quadro e não retornar valor
            _nome = null;
            this.Close();
        }
    }
}
