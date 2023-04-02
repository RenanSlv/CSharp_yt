using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca
{
    public partial class Heranca : Form
    {
        public Heranca()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {

            ////Erro pq classe é abstrata só pode ser herdada
            //cl_veiculo veiculo = new cl_veiculo();
            cl_carro carro = new cl_carro();
            cl_bicicleta bicicleta = new cl_bicicleta();

            carro.Acelerar();
            bicicleta.Acelerar();
        }
    }
}
