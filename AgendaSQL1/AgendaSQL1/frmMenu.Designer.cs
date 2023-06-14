namespace AgendaSQL1
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.cmd_adicionar = new System.Windows.Forms.Button();
            this.cmd_visualizar = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.cmd_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Location = new System.Drawing.Point(92, 195);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(114, 54);
            this.cmd_pesquisar.TabIndex = 2;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // label_titulo
            // 
            this.label_titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(12, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(275, 52);
            this.label_titulo.TabIndex = 5;
            this.label_titulo.Text = "Agenda SQL";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_titulo.Click += new System.EventHandler(this.label_titulo_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(92, 315);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(114, 54);
            this.cmd_sair.TabIndex = 3;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_adicionar
            // 
            this.cmd_adicionar.Location = new System.Drawing.Point(92, 135);
            this.cmd_adicionar.Name = "cmd_adicionar";
            this.cmd_adicionar.Size = new System.Drawing.Size(114, 54);
            this.cmd_adicionar.TabIndex = 1;
            this.cmd_adicionar.Text = "Adicionar";
            this.cmd_adicionar.UseVisualStyleBackColor = true;
            this.cmd_adicionar.Click += new System.EventHandler(this.cmd_adicionar_Click);
            // 
            // cmd_visualizar
            // 
            this.cmd_visualizar.Location = new System.Drawing.Point(92, 75);
            this.cmd_visualizar.Name = "cmd_visualizar";
            this.cmd_visualizar.Size = new System.Drawing.Size(114, 54);
            this.cmd_visualizar.TabIndex = 0;
            this.cmd_visualizar.Text = "Vizualizar Tudo";
            this.cmd_visualizar.UseVisualStyleBackColor = true;
            this.cmd_visualizar.Click += new System.EventHandler(this.cmd_visualizar_Click);
            // 
            // label_versao
            // 
            this.label_versao.Location = new System.Drawing.Point(12, 388);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(275, 22);
            this.label_versao.TabIndex = 4;
            this.label_versao.Text = "v1.0";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_reset
            // 
            this.cmd_reset.Location = new System.Drawing.Point(92, 255);
            this.cmd_reset.Name = "cmd_reset";
            this.cmd_reset.Size = new System.Drawing.Size(114, 54);
            this.cmd_reset.TabIndex = 6;
            this.cmd_reset.Text = "Reset";
            this.cmd_reset.UseVisualStyleBackColor = true;
            this.cmd_reset.Click += new System.EventHandler(this.cmd_reset_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 420);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_reset);
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.cmd_visualizar);
            this.Controls.Add(this.cmd_adicionar);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.cmd_pesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Button cmd_adicionar;
        private System.Windows.Forms.Button cmd_visualizar;
        private System.Windows.Forms.Label label_versao;
        private System.Windows.Forms.Button cmd_reset;
    }
}

