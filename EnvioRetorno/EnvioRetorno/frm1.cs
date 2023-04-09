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
    public partial class frm1 : Form
    {
        string _Nome = null;
        public frm1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //defina nome
            if(label_txt.Text != "")
                _Nome = label_txt.Text;

            frm2 formulario = new frm2(_Nome);
            formulario.ShowDialog();

            if(formulario._nome != null )
                label_txt.Text = formulario._nome;
        }
    }
}
