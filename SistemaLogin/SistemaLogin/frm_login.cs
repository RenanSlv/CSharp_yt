using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing.Text;

namespace SistemaLogin
{
    public partial class frm_login : Form
    {
        //dados do utilizador
        string utilizador = "manuel";
        string password = "123456";
        public frm_login()
        {
            InitializeComponent();
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_entrar_Click(object sender, EventArgs e)
        {
            //verificar se o login é corre
            if (text_nome.Text == "" || text_password.Text == "") return;
            bool entrar = true;

            string codigo = CriarMD5(text_password.Text);

            //verifica se house falha de introdução dos dados
            if (text_nome.Text != utilizador || codigo != CriarMD5(password))
            {
                MessageBox.Show("Dados de login inválidos.");
                entrar = false;
            }

            //se o login é corre, abre o menu principal
            if (entrar) 
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //visualiza ou esconde o texto do password
            if (checkBox1.Checked)
            {
                //mostrar password
                text_password.PasswordChar = '\0';
            }
            else 
            {
                //esconder password
                text_password.PasswordChar = '*';
            }  
        }
        private string CriarMD5(string texto) 
        {
            //encriptar com o algoritmo MD5 o texto fornecido.
            MD5 criador = MD5.Create();
            byte[] inputs = Encoding.ASCII.GetBytes(texto);
            byte[] hash = criador.ComputeHash(inputs);

            StringBuilder final = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) 
            {
                final.Append((hash[i]).ToString("X2"));
            }
            
            return final.ToString();
        }
    }
}
