namespace Agenda1
{
    partial class frmPesquisa
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.cmd_pesquisarPSQ = new System.Windows.Forms.Button();
            this.cmd_cancelarPSQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Termo de pesquisa:";
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(13, 30);
            this.textBox_pesquisa.MaxLength = 30;
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(214, 20);
            this.textBox_pesquisa.TabIndex = 0;
            this.textBox_pesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pesquisa_KeyDown);
            // 
            // cmd_pesquisarPSQ
            // 
            this.cmd_pesquisarPSQ.Location = new System.Drawing.Point(16, 66);
            this.cmd_pesquisarPSQ.Name = "cmd_pesquisarPSQ";
            this.cmd_pesquisarPSQ.Size = new System.Drawing.Size(75, 23);
            this.cmd_pesquisarPSQ.TabIndex = 1;
            this.cmd_pesquisarPSQ.Text = "Pesquisar";
            this.cmd_pesquisarPSQ.UseVisualStyleBackColor = true;
            this.cmd_pesquisarPSQ.Click += new System.EventHandler(this.cmd_pesquisarPSQ_Click);
            this.cmd_pesquisarPSQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmd_pesquisarPSQ_KeyDown);
            // 
            // cmd_cancelarPSQ
            // 
            this.cmd_cancelarPSQ.Location = new System.Drawing.Point(152, 66);
            this.cmd_cancelarPSQ.Name = "cmd_cancelarPSQ";
            this.cmd_cancelarPSQ.Size = new System.Drawing.Size(75, 23);
            this.cmd_cancelarPSQ.TabIndex = 2;
            this.cmd_cancelarPSQ.Text = "Cancelar";
            this.cmd_cancelarPSQ.UseVisualStyleBackColor = true;
            this.cmd_cancelarPSQ.Click += new System.EventHandler(this.cmd_cancelarPSQ_Click);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 101);
            this.Controls.Add(this.cmd_cancelarPSQ);
            this.Controls.Add(this.cmd_pesquisarPSQ);
            this.Controls.Add(this.textBox_pesquisa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.Button cmd_pesquisarPSQ;
        private System.Windows.Forms.Button cmd_cancelarPSQ;
    }
}