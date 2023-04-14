namespace Conversao
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
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.cmd_ler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Location = new System.Drawing.Point(84, 290);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(96, 51);
            this.cmd_gravar.TabIndex = 0;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // cmd_ler
            // 
            this.cmd_ler.Location = new System.Drawing.Point(303, 290);
            this.cmd_ler.Name = "cmd_ler";
            this.cmd_ler.Size = new System.Drawing.Size(100, 51);
            this.cmd_ler.TabIndex = 1;
            this.cmd_ler.Text = "Ler";
            this.cmd_ler.UseVisualStyleBackColor = true;
            this.cmd_ler.Click += new System.EventHandler(this.cmd_ler_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox1.Location = new System.Drawing.Point(303, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 58);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmd_ler);
            this.Controls.Add(this.cmd_gravar);
            this.Name = "Form1";
            this.Text = "Conversão";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.Button cmd_ler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

