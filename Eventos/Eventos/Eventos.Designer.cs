namespace Eventos
{
    partial class Eventos
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
            this.label_a = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(284, 358);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar.TabIndex = 0;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // label_a
            // 
            this.label_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_a.Location = new System.Drawing.Point(12, 13);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(388, 75);
            this.label_a.TabIndex = 1;
            this.label_a.Click += new System.EventHandler(this.label_a_Click);
            this.label_a.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_a_MouseDown);
            this.label_a.MouseEnter += new System.EventHandler(this.label_a_MouseEnter);
            this.label_a.MouseLeave += new System.EventHandler(this.label_a_MouseLeave);
            this.label_a.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_a_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 404);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.cmd_executar);
            this.Name = "Eventos";
            this.Text = "Eventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.TextBox textBox1;
    }
}

