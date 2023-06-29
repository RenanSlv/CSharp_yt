using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impressao1
{
    public partial class Form1 : Form
    {

        int largura, altura;

        Font letra;
        SolidBrush cor;
        int y = 50;
        int num_frase = 1;
        int pagina = 0;
        int paginas_criadas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instrução para iniciar a impressão
            //lista.Items.Add(documento.DefaultPageSettings.Bounds.X.ToString());
            //lista.Items.Add(documento.DefaultPageSettings.Bounds.Y.ToString());
            //lista.Items.Add(documento.DefaultPageSettings.Bounds.Width.ToString());
            //lista.Items.Add(documento.DefaultPageSettings.Bounds.Height.ToString());

            //preparar a impressão
            largura = documento.DefaultPageSettings.Bounds.Width;
            altura = documento.DefaultPageSettings.Bounds.Height;

            letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            cor = new SolidBrush(Color.Black);
            //y= 50;
            //num_frase = 1;
            //pagina = 0;

            ////abrir o quadro de configuração de impressora
            //if (caixa_setup.ShowDialog() == DialogResult.Cancel)
            //    return;
            //else
            //    documento.PrinterSettings = caixa_setup.PrinterSettings;//mudando ou deixando a impressora padrao

            //documento.Print();

            //
            //paginas_criadas = 0;
            //visualizarDoc.Document = documento;
            //visualizarDoc.InvalidatePreview();


            documento.DefaultPageSettings.Landscape = true;
            y = 100;


            caixaVisualizacao.Document = documento;
            caixaVisualizacao.ShowDialog();

        }

        private void pagina_seguinte_Click(object sender, EventArgs e)
        {
            if(pagina == paginas_criadas)
                return;
            pagina++;
            visualizarDoc.StartPage = pagina;
        }

        private void retrocede_pagina_Click(object sender, EventArgs e)
        {
            if (pagina == 0)
                return;
            pagina--;
            visualizarDoc.StartPage = pagina;
        }

        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            #region Imprimir
            //// PRIMEIRA IMPRESSÂO
            ////imprime os dados do documento
            //string texto = $@"Primeira fraze para imprimir em C#";
            //Font letra = new Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            //SolidBrush cor = new SolidBrush(Color.Black);
            ////Point ponto = new Point(100, 100);
            //Rectangle rect = new Rectangle(0, 100, largura, 30);
            //StringFormat alinhamento = new StringFormat();
            //alinhamento.Alignment = StringAlignment.Center;
            //alinhamento.LineAlignment = StringAlignment.Center;


            //List<string> lista = new List<string>() 
            //{ 
            //    "frase numero um",
            //    "frase numero dois",
            //    "frase numero tres",
            //    "frase numero quadro",
            //    "frase numero cinco",
            //    "frase numero seis",
            //};


            ////instrução para imprimir na folha
            //e.Graphics.DrawString(texto.ToUpper(), letra, cor, rect, alinhamento);
            #endregion

            ////apresentar frases
            //int y = 140;
            //foreach (string str in lista) 
            //{
            //    e.Graphics.DrawString(str,letra,cor,new Point(100,y));
            //    y += 20;
            //}

            //y += 50;
            //string texto1 = "Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. Este texto vai ser apresentado dentro de uma caixa de texto. ";
            //alinhamento.Alignment = StringAlignment.Near;
            //alinhamento.LineAlignment = StringAlignment.Near;
            //e.Graphics.DrawString(texto1, letra, cor, new Rectangle(100,y,600,200), alinhamento);
            //e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(100,y,600,200));

            //while (num_frase <= 100) 
            //{
            //    e.Graphics.DrawString($@"frase número {num_frase}", letra, cor, new Point(50,y));
            //    y += 30;
            //    num_frase++;

            //    //se o documento chegou ao final da página
            //    if (y >= altura - 50) 
            //    {
            //        //mudar de página
            //        y = 50;
            //        e.HasMorePages = true;// adicionar pagina
            //        paginas_criadas++;
            //        break;
            //    }

            //}


            //e.Graphics.DrawString("Texto", letra, cor, new Point(100,100));

            string frase = "Esta frase serve para testes.";
            SizeF dimensao = e.Graphics.MeasureString(frase,letra);

            
            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            y += Convert.ToInt32(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            y += Convert.ToInt32(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            y += Convert.ToInt32(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            y += Convert.ToInt32(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            y += Convert.ToInt32(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            y += Convert.ToInt32(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            y += Convert.ToInt32(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(100, y));
            

            //desenhar a linha
            e.Graphics.DrawLine(new Pen(Color.Red,2),
                                new Point(100 + (int)dimensao.Width, 100),
                                new Point(100 + (int)dimensao.Width, y + (int)dimensao.Height)
                                );

        }
    }
}
