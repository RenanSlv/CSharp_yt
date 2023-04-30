namespace LigacaoBD
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
            this.btn_ligacao = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ligacao
            // 
            this.btn_ligacao.Location = new System.Drawing.Point(12, 349);
            this.btn_ligacao.Name = "btn_ligacao";
            this.btn_ligacao.Size = new System.Drawing.Size(107, 42);
            this.btn_ligacao.TabIndex = 0;
            this.btn_ligacao.Text = "Ligação";
            this.btn_ligacao.UseVisualStyleBackColor = true;
            this.btn_ligacao.Click += new System.EventHandler(this.btn_ligacao_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(13, 13);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(35, 13);
            this.label_resultado.TabIndex = 1;
            this.label_resultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 403);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.btn_ligacao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ligacao;
        private System.Windows.Forms.Label label_resultado;
    }
}

