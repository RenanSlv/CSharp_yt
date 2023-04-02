namespace Enumeracoes
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
            this.cmd_executar = new System.Windows.Forms.Button();
            this.cmd_cima = new System.Windows.Forms.Button();
            this.cmd_esquerda = new System.Windows.Forms.Button();
            this.cmd_direita = new System.Windows.Forms.Button();
            this.cmd_baixo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(170, 255);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(144, 63);
            this.cmd_executar.TabIndex = 0;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // cmd_cima
            // 
            this.cmd_cima.Location = new System.Drawing.Point(156, 27);
            this.cmd_cima.Name = "cmd_cima";
            this.cmd_cima.Size = new System.Drawing.Size(75, 23);
            this.cmd_cima.TabIndex = 1;
            this.cmd_cima.Text = "Cima";
            this.cmd_cima.UseVisualStyleBackColor = true;
            this.cmd_cima.Click += new System.EventHandler(this.cmd_cima_Click);
            // 
            // cmd_esquerda
            // 
            this.cmd_esquerda.Location = new System.Drawing.Point(87, 56);
            this.cmd_esquerda.Name = "cmd_esquerda";
            this.cmd_esquerda.Size = new System.Drawing.Size(75, 23);
            this.cmd_esquerda.TabIndex = 2;
            this.cmd_esquerda.Text = "Esquerda";
            this.cmd_esquerda.UseVisualStyleBackColor = true;
            this.cmd_esquerda.Click += new System.EventHandler(this.cmd_esquerda_Click);
            // 
            // cmd_direita
            // 
            this.cmd_direita.Location = new System.Drawing.Point(226, 56);
            this.cmd_direita.Name = "cmd_direita";
            this.cmd_direita.Size = new System.Drawing.Size(75, 23);
            this.cmd_direita.TabIndex = 3;
            this.cmd_direita.Text = "Direita";
            this.cmd_direita.UseVisualStyleBackColor = true;
            this.cmd_direita.Click += new System.EventHandler(this.cmd_direita_Click);
            // 
            // cmd_baixo
            // 
            this.cmd_baixo.Location = new System.Drawing.Point(156, 85);
            this.cmd_baixo.Name = "cmd_baixo";
            this.cmd_baixo.Size = new System.Drawing.Size(75, 23);
            this.cmd_baixo.TabIndex = 4;
            this.cmd_baixo.Text = "Baixo";
            this.cmd_baixo.UseVisualStyleBackColor = true;
            this.cmd_baixo.Click += new System.EventHandler(this.cmd_baixo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 361);
            this.Controls.Add(this.cmd_baixo);
            this.Controls.Add(this.cmd_direita);
            this.Controls.Add(this.cmd_esquerda);
            this.Controls.Add(this.cmd_cima);
            this.Controls.Add(this.cmd_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.Button cmd_cima;
        private System.Windows.Forms.Button cmd_esquerda;
        private System.Windows.Forms.Button cmd_direita;
        private System.Windows.Forms.Button cmd_baixo;
    }
}

