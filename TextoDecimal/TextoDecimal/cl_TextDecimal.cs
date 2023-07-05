using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextoDecimal
{
    public class cl_TextDecimal : TextBox
    {

        //enumeração da virgula e do ponto
        public enum EnumSeparador
        {
            Virgula,
            Ponto
        }


        //propriedades (campos)
        private double _minValor = 0;
        private double _maxValor = 100;
        private bool _permitirDecimais = true;
        private int _numeroCasasDecimais = 2;
        private double _valorDefeito = 0;
        private EnumSeparador _separador = EnumSeparador.Virgula;

        #region Operacionalização das propriedades

        //valor minimo
        public double ValorMinimo
        {
            get { return _minValor; }
            set { _minValor = value; }
        }

        //valor máximo
        public double ValorMaximo
        {
            get { return _maxValor; }
            set { _maxValor = value; }
        }

        public bool PermitirDecimais
        {
            get { return _permitirDecimais; }
            set { _permitirDecimais = value; }
        }

        //número de dígitos na parte decimal
        public int NumeroCasasDecimais
        {
            get { return _numeroCasasDecimais; }
            set { _numeroCasasDecimais = value; }
        }

        //valor por defeito
        public double ValorPorDefeito
        {
            get { return _valorDefeito; }
            set { _valorDefeito = value; }
        }

        //define o tipo de separador decimal
        public EnumSeparador SeparadorDecimal
        {
            get { return _separador; }
            set { _separador = value; }
        }

        #endregion

        //
        public cl_TextDecimal()
        {
            //eventos da caixa de texto com casas decimais
            this.KeyPress += Cl_TextDecimal_KeyPress;
            this.LostFocus += Cl_TextDecimal_LostFocus;
            this.TextChanged += Cl_TextDecimal_TextChanged;

        }

        private void Cl_TextDecimal_TextChanged(object sender, EventArgs e)
        {
            //verifica quando o texto é alterado
            if (this.Focused) return;
            if (this.Text == "") return;

            //verificar se o valor atribuido à caixa está dentro do limite da textbox
            try
            {
                double valor = double.Parse(this.Text);

                //verifica se o valor é inferior ao mínimo
                if (valor < _minValor) 
                {
                    valor = _minValor;
                    this.Text = valor.ToString();
                    Cl_TextDecimal_LostFocus(this, EventArgs.Empty);
                    return;
                }

                //verifica se o valor é superior ao máximo
                if (valor > _maxValor) 
                {
                    valor = _maxValor;
                    this.Text = valor.ToString();
                    Cl_TextDecimal_LostFocus(this, EventArgs.Empty);
                    return;
                }

                    
            }
            catch
            {
                this.Text = _valorDefeito.ToString();
                Cl_TextDecimal_LostFocus(this, EventArgs.Empty);
            }
        }

        private void Cl_TextDecimal_LostFocus(object sender, EventArgs e)
        {
            //operações quando a caixa perde o focus
            if (this.Text == "") return;

            //--------------------------------------------------
            // verifica qual é o separador
            char separador = ',';
            if (_separador == EnumSeparador.Ponto) separador = '.';

            //subbtitui o separador, caso ele exita na caixa e seja diferente do selecionar
            if (separador == ',') 
                this.Text = this.Text.Replace('.', ',');
            else
                this.Text = this.Text.Replace(',', '.');

            //se o valor inserido for apenas um separador
            if (this.Text == separador.ToString())
            {
                if (_permitirDecimais)
                    this.Text = _valorDefeito.ToString();
            }

            //no caso de ter casas decimais, verifica se estão corretas
            if (_permitirDecimais && this.Text.Contains(separador)) 
            {
                //se o numero de casa decimais não é válido ...
                string[] valores = this.Text.Split(separador);

                //se o numero de casas decimais é inferior ao definido..
                if (valores[1].Length < _numeroCasasDecimais) 
                {
                    int emFalta = _numeroCasasDecimais - valores[1].Length;
                    valores[1] = valores[1] + new string('0', emFalta);
                    this.Text = valores[0] + separador + valores[1];
                }

                //se o numero de casa decimais é superior ao definido
                if (valores[1].Length > _numeroCasasDecimais) 
                {
                    double resultado = Math.Round(double.Parse(this.Text), _numeroCasasDecimais);
                    this.Text = resultado.ToString();
                }

                //se o texto começar com sinal negativo mas começa logo com o separador
                if (this.Text.Contains('-')) 
                {
                    int localizacao = this.Text.IndexOf('-');
                    if (localizacao != 0)
                        this.Text = "0";
                }

                double valor = double.Parse(this.Text);
                this.Text = valor.ToString();

                //verifica se foi respeitado o limite min e max 
                if (valor < _minValor)
                {
                    this.Text = _minValor.ToString();
                    Cl_TextDecimal_LostFocus(this, EventArgs.Empty);
                }
                else if (valor > _maxValor) 
                {
                    this.Text = _maxValor.ToString();
                    Cl_TextDecimal_LostFocus(this, EventArgs.Empty);
                }
                
            }
        }

        private void Cl_TextDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //executa operações quando o utilizador pressiona teclas
            int[] codigosTeclas;
            if (_permitirDecimais)
                codigosTeclas = new int[] { 44, 45, 46, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8 };
            else
                codigosTeclas = new int[] { 45, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8 };

            //verifica se o caracter é válido
            if (!codigosTeclas.Contains(e.KeyChar)) 
            {
                e.Handled = true;
                return;
            }

            //verifica o separador
            if (_permitirDecimais)
            {
                char valido = ',';
                char invalido = '.';
                if (_separador == EnumSeparador.Ponto) 
                {
                    valido = '.';
                    invalido = ',';
                }

                //verifica se pode ser inserido o separados
                if (e.KeyChar == valido || e.KeyChar == invalido)
                {
                    if (this.Text.Contains(valido))
                    {
                        e.Handled = true;
                        return;
                    }

                    //verifica se é necessário substituir o separador
                    if (e.KeyChar == invalido)
                        e.KeyChar = valido;
                }
            }

            //verifica se já tem um sinal negativo
            if (this.Text.Contains('-') && e.KeyChar == '-')
            {
                e.Handled = true;
                return;
            }

            //verifica se está tentando colocar um sinal negativo após um separador
            char charValido = _separador == EnumSeparador.Virgula ? ',' : '.';
            //^^
            //if (_separador == EnumSeparador.Ponto)
            //    charValido = '.';
            //else
            //    charValido = ',';

            if (this.Text.Contains(charValido)) 
            {
                if (this.Text.IndexOf(charValido) < this.SelectionStart && e.KeyChar == '-')
                { 
                    e.Handled = true;
                    return;
                }
            }


        }
    }
}
