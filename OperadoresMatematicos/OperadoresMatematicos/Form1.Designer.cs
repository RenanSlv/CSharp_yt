namespace OperadoresMatematicos
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
            this.label_resultado = new System.Windows.Forms.Label();
            this.text_parcela_1 = new System.Windows.Forms.TextBox();
            this.text_parcela_2 = new System.Windows.Forms.TextBox();
            this.cmd_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(12, 188);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar.TabIndex = 0;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(12, 128);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(0, 13);
            this.label_resultado.TabIndex = 1;
            // 
            // text_parcela_1
            // 
            this.text_parcela_1.Location = new System.Drawing.Point(15, 30);
            this.text_parcela_1.Name = "text_parcela_1";
            this.text_parcela_1.Size = new System.Drawing.Size(100, 20);
            this.text_parcela_1.TabIndex = 2;
            // 
            // text_parcela_2
            // 
            this.text_parcela_2.Location = new System.Drawing.Point(15, 68);
            this.text_parcela_2.Name = "text_parcela_2";
            this.text_parcela_2.Size = new System.Drawing.Size(100, 20);
            this.text_parcela_2.TabIndex = 3;
            // 
            // cmd_exit
            // 
            this.cmd_exit.Location = new System.Drawing.Point(147, 188);
            this.cmd_exit.Name = "cmd_exit";
            this.cmd_exit.Size = new System.Drawing.Size(75, 23);
            this.cmd_exit.TabIndex = 4;
            this.cmd_exit.Text = "Exit";
            this.cmd_exit.UseVisualStyleBackColor = true;
            this.cmd_exit.Click += new System.EventHandler(this.cmd_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 296);
            this.Controls.Add(this.cmd_exit);
            this.Controls.Add(this.text_parcela_2);
            this.Controls.Add(this.text_parcela_1);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.cmd_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox text_parcela_1;
        private System.Windows.Forms.TextBox text_parcela_2;
        private System.Windows.Forms.Button cmd_exit;
    }
}

