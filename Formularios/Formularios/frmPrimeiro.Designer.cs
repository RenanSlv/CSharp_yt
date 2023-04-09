namespace Formularios
{
    partial class frmPrimeiro
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
            this.cmd_1 = new System.Windows.Forms.Button();
            this.cmd_2 = new System.Windows.Forms.Button();
            this.cmd_exit = new System.Windows.Forms.Button();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_1
            // 
            this.cmd_1.Location = new System.Drawing.Point(93, 163);
            this.cmd_1.Name = "cmd_1";
            this.cmd_1.Size = new System.Drawing.Size(147, 77);
            this.cmd_1.TabIndex = 0;
            this.cmd_1.Text = "frmUm";
            this.cmd_1.UseVisualStyleBackColor = true;
            this.cmd_1.Click += new System.EventHandler(this.cmd_1_Click);
            // 
            // cmd_2
            // 
            this.cmd_2.Location = new System.Drawing.Point(93, 246);
            this.cmd_2.Name = "cmd_2";
            this.cmd_2.Size = new System.Drawing.Size(147, 80);
            this.cmd_2.TabIndex = 1;
            this.cmd_2.Text = "frmDois";
            this.cmd_2.UseVisualStyleBackColor = true;
            this.cmd_2.Click += new System.EventHandler(this.cmd_2_Click);
            // 
            // cmd_exit
            // 
            this.cmd_exit.Location = new System.Drawing.Point(253, 314);
            this.cmd_exit.Name = "cmd_exit";
            this.cmd_exit.Size = new System.Drawing.Size(109, 46);
            this.cmd_exit.TabIndex = 2;
            this.cmd_exit.Text = "Exit";
            this.cmd_exit.UseVisualStyleBackColor = true;
            this.cmd_exit.Click += new System.EventHandler(this.cmd_exit_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(12, 51);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(269, 20);
            this.textBox_nome.TabIndex = 3;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(12, 35);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(38, 13);
            this.label_nome.TabIndex = 4;
            this.label_nome.Text = "Nome:";
            // 
            // frmPrimeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 372);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.cmd_exit);
            this.Controls.Add(this.cmd_2);
            this.Controls.Add(this.cmd_1);
            this.Name = "frmPrimeiro";
            this.Text = "Primeiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_1;
        private System.Windows.Forms.Button cmd_2;
        private System.Windows.Forms.Button cmd_exit;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_nome;
    }
}

