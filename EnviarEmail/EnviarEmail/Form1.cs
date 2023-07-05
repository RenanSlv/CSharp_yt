using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace EnviarEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_enviar_Click(object sender, EventArgs e)
        {
            // para mandar email tem que adicionar System.Net e System.Net.mail

            SmtpClient cliente = new SmtpClient();
            NetworkCredential cred = new NetworkCredential();

            //definir as configurações do cliente
            cliente.Host = "smtp.office365.com";
            cliente.Port = 587;
            //cliente.Timeout = 60*60;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network; // metodo de entrega
            cliente.UseDefaultCredentials = false;
            
            
            //definir as credenciais de acesso ao email
            cred.UserName = "renan.romulo@outlook.com";
            cred.Password = "123456";

            //define as credenciais no cliente
            cliente.Credentials = cred;

            //preparar a mensagem a enviar
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("renan.romulo@outlook.com");
            mensagem.Subject = "Mensagem em HTML";
            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h3><strong><u>CUIDADO:</u></strong></h3><br><br> A sua conta de correio está sendo usada por uma aplicação externa.";
            mensagem.To.Add("renan.romulo@outlook.com");
            mensagem.Priority = MailPriority.Normal;

            //envio da mensagem de email
            try
            {
                cliente.Send(mensagem); 
                MessageBox.Show("Mensagem enviada com Sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;

            bool resultado = true;

            //verificação do endereço de e-mail
            Regex reg = new Regex(@"(\w+@[a-zA-Z_]+?.[a-zA-Z]{2,6})");
            if (reg.IsMatch(email)==false) 
                resultado = false;

            //verifica se o email tem mais de um @
            int num_ats = 0;
            foreach (char c in email) 
            {
                if(c=='@')
                    num_ats++;
            };

            if(num_ats != 1)
                resultado=false;

            //verificar se o email é correto
            if (!resultado)
                MessageBox.Show("Email inválido");
        }
    }
}
