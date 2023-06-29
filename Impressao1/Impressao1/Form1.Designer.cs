namespace Impressao1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.lista = new System.Windows.Forms.ListBox();
            this.caixa_setup = new System.Windows.Forms.PrintDialog();
            this.visualizarDoc = new System.Windows.Forms.PrintPreviewControl();
            this.pagina_seguinte = new System.Windows.Forms.Button();
            this.retrocede_pagina = new System.Windows.Forms.Button();
            this.caixaVisualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(445, 20);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(97, 212);
            this.lista.TabIndex = 1;
            // 
            // caixa_setup
            // 
            this.caixa_setup.UseEXDialog = true;
            // 
            // visualizarDoc
            // 
            this.visualizarDoc.Location = new System.Drawing.Point(13, 13);
            this.visualizarDoc.Name = "visualizarDoc";
            this.visualizarDoc.Size = new System.Drawing.Size(426, 377);
            this.visualizarDoc.TabIndex = 2;
            // 
            // pagina_seguinte
            // 
            this.pagina_seguinte.Location = new System.Drawing.Point(445, 278);
            this.pagina_seguinte.Name = "pagina_seguinte";
            this.pagina_seguinte.Size = new System.Drawing.Size(97, 34);
            this.pagina_seguinte.TabIndex = 3;
            this.pagina_seguinte.Text = "Next page";
            this.pagina_seguinte.UseVisualStyleBackColor = true;
            this.pagina_seguinte.Click += new System.EventHandler(this.pagina_seguinte_Click);
            // 
            // retrocede_pagina
            // 
            this.retrocede_pagina.Location = new System.Drawing.Point(445, 318);
            this.retrocede_pagina.Name = "retrocede_pagina";
            this.retrocede_pagina.Size = new System.Drawing.Size(97, 34);
            this.retrocede_pagina.TabIndex = 4;
            this.retrocede_pagina.Text = "Back page";
            this.retrocede_pagina.UseVisualStyleBackColor = true;
            this.retrocede_pagina.Click += new System.EventHandler(this.retrocede_pagina_Click);
            // 
            // caixaVisualizacao
            // 
            this.caixaVisualizacao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.caixaVisualizacao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.caixaVisualizacao.ClientSize = new System.Drawing.Size(400, 300);
            this.caixaVisualizacao.Enabled = true;
            this.caixaVisualizacao.Icon = ((System.Drawing.Icon)(resources.GetObject("caixaVisualizacao.Icon")));
            this.caixaVisualizacao.Name = "caixaVisualizacao";
            this.caixaVisualizacao.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 402);
            this.Controls.Add(this.retrocede_pagina);
            this.Controls.Add(this.pagina_seguinte);
            this.Controls.Add(this.visualizarDoc);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.PrintDialog caixa_setup;
        private System.Windows.Forms.PrintPreviewControl visualizarDoc;
        private System.Windows.Forms.Button pagina_seguinte;
        private System.Windows.Forms.Button retrocede_pagina;
        private System.Windows.Forms.PrintPreviewDialog caixaVisualizacao;
    }
}

