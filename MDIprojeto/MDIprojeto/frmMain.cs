using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIprojeto
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Multi Documents Interface MDI
            frmUm f = new frmUm(this);
            f.Show();

        }

        private void menu_abrir_Click(object sender, EventArgs e)
        {
            //frmUm f = new frmUm();
            //f.MdiParent = this;
            //f.Show();

            frmUm f = new frmUm(this);
            f.Show();
        }
    }
}
