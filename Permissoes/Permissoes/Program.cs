using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Permissoes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static bool VerificarPermissao(cl_utilizador user, int opcao) 
        {
            //verifica se o utilizador tem permissao para aceder à funcionalidade
            bool resultado = true;
            if (user.permissoes[opcao] == '0')
                resultado = false;

            if (!resultado)
                MessageBox.Show("Não tem permissão");

            return resultado;
        }
    }
}
