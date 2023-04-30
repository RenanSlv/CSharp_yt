using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //fechar a aplicação
            Application.Exit();
        }

        private void cmd_calcular_Click(object sender, EventArgs e)
        {
            //executa o cálculo da operação
            int parcela1=0, parcela2=0, resultado = -111111111;
            string operador;

            string algoritmo = textBox_operacoes.Text;
            string sinais = "+-*/";

            int index = 0;
            foreach (char c in algoritmo) 
            {
                foreach (char s in sinais) 
                {
                    if (c == s) 
                    {
                        //define os 3 elementos da operação      Breakpoint F9, F11 vai indo para frente;
                        //define parcela1
                        parcela1 = int.Parse(algoritmo.Substring(0, index));

                        //sinal
                        operador = c.ToString();

                        //define parcela2
                        parcela2 = Convert.ToInt32(algoritmo.Substring(index + 1));

                        //analisa a operação que vai ser realizada

                        switch (operador)
                        {
                            case "+":
                                resultado = parcela1 + parcela2;
                                break;
                            case "-":
                                resultado = parcela1 - parcela2;
                                break;
                            case "*":
                                resultado = parcela1 * parcela2;
                                break;
                            case "/":
                                resultado = parcela1 / parcela2;
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                }
                //analisa resultado
                if (resultado != -111111111)
                    break;
                
                index++;
            }
            //Apresentação do resultado final
            //textBox_operacoes.Text = resultado.ToString();
            if (resultado == -111111111)
                MessageBox.Show("Erro na operação", "ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show($@"{algoritmo} = {resultado}");
            textBox_operacoes.Text = "";
            textBox_operacoes.Focus();
        }

        private void textBox_operacoes_KeyDown(object sender, KeyEventArgs e)
        {
            //Ao clicar Enter executa a Operação exceto quando não existir texto

            //verifica se exite texto
            if (textBox_operacoes.Text == "") return;

            //analiza se foi pressionada a tecla Enter
            if (e.KeyCode == Keys.Return)
                cmd_calcular_Click(cmd_calcular, EventArgs.Empty);
            else if (e.KeyCode == Keys.Escape)
            {
                textBox_operacoes.Text = "";
                textBox_operacoes.Focus();
            }
        }
    }
}
