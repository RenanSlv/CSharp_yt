namespace ProjetoFinal_Sis_Instalacao
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
            this.cmd_sair = new System.Windows.Forms.Button();
            this.cmd_carregar = new System.Windows.Forms.Button();
            this.pic_imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(371, 305);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(75, 23);
            this.cmd_sair.TabIndex = 0;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_carregar
            // 
            this.cmd_carregar.Location = new System.Drawing.Point(371, 256);
            this.cmd_carregar.Name = "cmd_carregar";
            this.cmd_carregar.Size = new System.Drawing.Size(75, 23);
            this.cmd_carregar.TabIndex = 1;
            this.cmd_carregar.Text = "Carregar";
            this.cmd_carregar.UseVisualStyleBackColor = true;
            this.cmd_carregar.Click += new System.EventHandler(this.cmd_carregar_Click);
            // 
            // pic_imagem
            // 
            this.pic_imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_imagem.Location = new System.Drawing.Point(13, 13);
            this.pic_imagem.Name = "pic_imagem";
            this.pic_imagem.Size = new System.Drawing.Size(352, 315);
            this.pic_imagem.TabIndex = 2;
            this.pic_imagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 340);
            this.Controls.Add(this.pic_imagem);
            this.Controls.Add(this.cmd_carregar);
            this.Controls.Add(this.cmd_sair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Programa para testar instalador";
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Button cmd_carregar;
        private System.Windows.Forms.PictureBox pic_imagem;
    }
}

