namespace Agenda1
{
    partial class frmInserirEditar
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
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_numero = new System.Windows.Forms.Label();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.listBox_dados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_registros = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(290, 389);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(89, 35);
            this.cmd_fechar.TabIndex = 3;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(68, 22);
            this.textBox_nome.MaxLength = 50;
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(283, 20);
            this.textBox_nome.TabIndex = 0;
            // 
            // label_nome
            // 
            this.label_nome.Location = new System.Drawing.Point(13, 25);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(49, 23);
            this.label_nome.TabIndex = 6;
            this.label_nome.Text = "Nome:";
            // 
            // label_numero
            // 
            this.label_numero.Location = new System.Drawing.Point(13, 51);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(49, 23);
            this.label_numero.TabIndex = 7;
            this.label_numero.Text = "Número";
            this.label_numero.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(68, 48);
            this.textBox_numero.MaxLength = 50;
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(283, 20);
            this.textBox_numero.TabIndex = 1;
            this.textBox_numero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Location = new System.Drawing.Point(68, 99);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(75, 23);
            this.cmd_gravar.TabIndex = 2;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // listBox_dados
            // 
            this.listBox_dados.FormattingEnabled = true;
            this.listBox_dados.Location = new System.Drawing.Point(5, 155);
            this.listBox_dados.Name = "listBox_dados";
            this.listBox_dados.Size = new System.Drawing.Size(372, 186);
            this.listBox_dados.TabIndex = 9;
            this.listBox_dados.SelectedIndexChanged += new System.EventHandler(this.listBox_dados_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista de contatos registrados:";
            // 
            // label_registros
            // 
            this.label_registros.AutoSize = true;
            this.label_registros.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registros.Location = new System.Drawing.Point(12, 358);
            this.label_registros.Name = "label_registros";
            this.label_registros.Size = new System.Drawing.Size(60, 15);
            this.label_registros.TabIndex = 10;
            this.label_registros.Text = "Registros : 0";
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(195, 389);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(89, 35);
            this.cmd_apagar.TabIndex = 4;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Location = new System.Drawing.Point(100, 389);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(89, 35);
            this.cmd_editar.TabIndex = 5;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // frmInserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 436);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_dados);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.label_numero);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserirEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda - Inserir/Editar";
            this.Load += new System.EventHandler(this.frmInserirEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.ListBox listBox_dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_registros;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
    }
}