namespace CamposPropriedades
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
            this.cmd_exit = new System.Windows.Forms.Button();
            this.label_txt = new System.Windows.Forms.Label();
            this.text_box1 = new System.Windows.Forms.TextBox();
            this.text_box2 = new System.Windows.Forms.TextBox();
            this.text_box3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(199, 330);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar.TabIndex = 0;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // cmd_exit
            // 
            this.cmd_exit.Location = new System.Drawing.Point(280, 330);
            this.cmd_exit.Name = "cmd_exit";
            this.cmd_exit.Size = new System.Drawing.Size(75, 23);
            this.cmd_exit.TabIndex = 1;
            this.cmd_exit.Text = "Exit";
            this.cmd_exit.UseVisualStyleBackColor = true;
            this.cmd_exit.Click += new System.EventHandler(this.cmd_exit_Click);
            // 
            // label_txt
            // 
            this.label_txt.AutoSize = true;
            this.label_txt.Location = new System.Drawing.Point(13, 13);
            this.label_txt.Name = "label_txt";
            this.label_txt.Size = new System.Drawing.Size(0, 13);
            this.label_txt.TabIndex = 2;
            // 
            // text_box1
            // 
            this.text_box1.Location = new System.Drawing.Point(12, 153);
            this.text_box1.Name = "text_box1";
            this.text_box1.Size = new System.Drawing.Size(100, 20);
            this.text_box1.TabIndex = 3;
            // 
            // text_box2
            // 
            this.text_box2.Location = new System.Drawing.Point(12, 205);
            this.text_box2.Name = "text_box2";
            this.text_box2.Size = new System.Drawing.Size(100, 20);
            this.text_box2.TabIndex = 4;
            // 
            // text_box3
            // 
            this.text_box3.Location = new System.Drawing.Point(12, 179);
            this.text_box3.Name = "text_box3";
            this.text_box3.Size = new System.Drawing.Size(100, 20);
            this.text_box3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 365);
            this.Controls.Add(this.text_box3);
            this.Controls.Add(this.text_box2);
            this.Controls.Add(this.text_box1);
            this.Controls.Add(this.label_txt);
            this.Controls.Add(this.cmd_exit);
            this.Controls.Add(this.cmd_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.Button cmd_exit;
        private System.Windows.Forms.Label label_txt;
        private System.Windows.Forms.TextBox text_box1;
        private System.Windows.Forms.TextBox text_box2;
        private System.Windows.Forms.TextBox text_box3;
    }
}

