namespace Calculadora1
{
    partial class calculadora
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
            this.cmd_calcular = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.textBox_operacoes = new System.Windows.Forms.TextBox();
            this.label_algoritmo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_calcular
            // 
            this.cmd_calcular.Location = new System.Drawing.Point(12, 118);
            this.cmd_calcular.Name = "cmd_calcular";
            this.cmd_calcular.Size = new System.Drawing.Size(75, 23);
            this.cmd_calcular.TabIndex = 1;
            this.cmd_calcular.Text = "Calcular";
            this.cmd_calcular.UseVisualStyleBackColor = true;
            this.cmd_calcular.Click += new System.EventHandler(this.cmd_calcular_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(129, 118);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(75, 23);
            this.cmd_sair.TabIndex = 2;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // textBox_operacoes
            // 
            this.textBox_operacoes.Location = new System.Drawing.Point(12, 68);
            this.textBox_operacoes.MaxLength = 30;
            this.textBox_operacoes.Name = "textBox_operacoes";
            this.textBox_operacoes.Size = new System.Drawing.Size(192, 20);
            this.textBox_operacoes.TabIndex = 0;
            this.textBox_operacoes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_operacoes_KeyDown);
            // 
            // label_algoritmo
            // 
            this.label_algoritmo.AutoSize = true;
            this.label_algoritmo.Location = new System.Drawing.Point(12, 34);
            this.label_algoritmo.Name = "label_algoritmo";
            this.label_algoritmo.Size = new System.Drawing.Size(100, 13);
            this.label_algoritmo.TabIndex = 3;
            this.label_algoritmo.Text = "Escreva o algoritmo";
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 160);
            this.Controls.Add(this.label_algoritmo);
            this.Controls.Add(this.textBox_operacoes);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_calcular;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.TextBox textBox_operacoes;
        private System.Windows.Forms.Label label_algoritmo;
    }
}

