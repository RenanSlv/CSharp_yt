namespace Agenda1
{
    partial class frmEdicao
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
            this.label_nomeEDIT = new System.Windows.Forms.Label();
            this.textBox_nomeEDIT = new System.Windows.Forms.TextBox();
            this.textBox_numeroEDIT = new System.Windows.Forms.TextBox();
            this.label_numeroEDIT = new System.Windows.Forms.Label();
            this.cmd_editarEDIT = new System.Windows.Forms.Button();
            this.cmd_cancelarEDIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nomeEDIT
            // 
            this.label_nomeEDIT.AutoSize = true;
            this.label_nomeEDIT.Location = new System.Drawing.Point(13, 38);
            this.label_nomeEDIT.Name = "label_nomeEDIT";
            this.label_nomeEDIT.Size = new System.Drawing.Size(38, 13);
            this.label_nomeEDIT.TabIndex = 0;
            this.label_nomeEDIT.Text = "Nome:";
            // 
            // textBox_nomeEDIT
            // 
            this.textBox_nomeEDIT.Location = new System.Drawing.Point(16, 55);
            this.textBox_nomeEDIT.Name = "textBox_nomeEDIT";
            this.textBox_nomeEDIT.Size = new System.Drawing.Size(217, 20);
            this.textBox_nomeEDIT.TabIndex = 1;
            // 
            // textBox_numeroEDIT
            // 
            this.textBox_numeroEDIT.Location = new System.Drawing.Point(16, 96);
            this.textBox_numeroEDIT.Name = "textBox_numeroEDIT";
            this.textBox_numeroEDIT.Size = new System.Drawing.Size(217, 20);
            this.textBox_numeroEDIT.TabIndex = 3;
            // 
            // label_numeroEDIT
            // 
            this.label_numeroEDIT.AutoSize = true;
            this.label_numeroEDIT.Location = new System.Drawing.Point(13, 79);
            this.label_numeroEDIT.Name = "label_numeroEDIT";
            this.label_numeroEDIT.Size = new System.Drawing.Size(47, 13);
            this.label_numeroEDIT.TabIndex = 2;
            this.label_numeroEDIT.Text = "Numero:";
            // 
            // cmd_editarEDIT
            // 
            this.cmd_editarEDIT.Location = new System.Drawing.Point(16, 151);
            this.cmd_editarEDIT.Name = "cmd_editarEDIT";
            this.cmd_editarEDIT.Size = new System.Drawing.Size(108, 40);
            this.cmd_editarEDIT.TabIndex = 4;
            this.cmd_editarEDIT.Text = "Editar";
            this.cmd_editarEDIT.UseVisualStyleBackColor = true;
            this.cmd_editarEDIT.Click += new System.EventHandler(this.cmd_editarEDIT_Click);
            // 
            // cmd_cancelarEDIT
            // 
            this.cmd_cancelarEDIT.Location = new System.Drawing.Point(126, 151);
            this.cmd_cancelarEDIT.Name = "cmd_cancelarEDIT";
            this.cmd_cancelarEDIT.Size = new System.Drawing.Size(108, 40);
            this.cmd_cancelarEDIT.TabIndex = 5;
            this.cmd_cancelarEDIT.Text = "Cancelar";
            this.cmd_cancelarEDIT.UseVisualStyleBackColor = true;
            this.cmd_cancelarEDIT.Click += new System.EventHandler(this.cmd_cancelarEDIT_Click);
            // 
            // frmEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 218);
            this.Controls.Add(this.cmd_cancelarEDIT);
            this.Controls.Add(this.cmd_editarEDIT);
            this.Controls.Add(this.textBox_numeroEDIT);
            this.Controls.Add(this.label_numeroEDIT);
            this.Controls.Add(this.textBox_nomeEDIT);
            this.Controls.Add(this.label_nomeEDIT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nomeEDIT;
        private System.Windows.Forms.TextBox textBox_nomeEDIT;
        private System.Windows.Forms.TextBox textBox_numeroEDIT;
        private System.Windows.Forms.Label label_numeroEDIT;
        private System.Windows.Forms.Button cmd_editarEDIT;
        private System.Windows.Forms.Button cmd_cancelarEDIT;
    }
}