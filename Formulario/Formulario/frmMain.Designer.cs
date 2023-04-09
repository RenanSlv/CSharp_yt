namespace Formulario
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_exit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(178, 338);
            this.cmd_executar.Margin = new System.Windows.Forms.Padding(10);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(100, 30);
            this.cmd_executar.TabIndex = 0;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmd_exit
            // 
            this.cmd_exit.Location = new System.Drawing.Point(291, 338);
            this.cmd_exit.Name = "cmd_exit";
            this.cmd_exit.Size = new System.Drawing.Size(100, 30);
            this.cmd_exit.TabIndex = 2;
            this.cmd_exit.Text = "Sair";
            this.cmd_exit.UseVisualStyleBackColor = true;
            this.cmd_exit.Click += new System.EventHandler(this.cmd_exit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 247);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 380);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmd_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_executar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_exit;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

