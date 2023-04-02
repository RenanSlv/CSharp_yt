namespace Encapsulamento
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
            this.radioButton_leite = new System.Windows.Forms.RadioButton();
            this.radioButton_martelo = new System.Windows.Forms.RadioButton();
            this.radioButton_perfume = new System.Windows.Forms.RadioButton();
            this.textBox_preco = new System.Windows.Forms.TextBox();
            this.cmd_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_leite
            // 
            this.radioButton_leite.AutoSize = true;
            this.radioButton_leite.Checked = true;
            this.radioButton_leite.Location = new System.Drawing.Point(12, 12);
            this.radioButton_leite.Name = "radioButton_leite";
            this.radioButton_leite.Size = new System.Drawing.Size(91, 17);
            this.radioButton_leite.TabIndex = 0;
            this.radioButton_leite.TabStop = true;
            this.radioButton_leite.Text = "Copo de Leite";
            this.radioButton_leite.UseVisualStyleBackColor = true;
            // 
            // radioButton_martelo
            // 
            this.radioButton_martelo.AutoSize = true;
            this.radioButton_martelo.Location = new System.Drawing.Point(12, 36);
            this.radioButton_martelo.Name = "radioButton_martelo";
            this.radioButton_martelo.Size = new System.Drawing.Size(60, 17);
            this.radioButton_martelo.TabIndex = 1;
            this.radioButton_martelo.Text = "Martelo";
            this.radioButton_martelo.UseVisualStyleBackColor = true;
            // 
            // radioButton_perfume
            // 
            this.radioButton_perfume.AutoSize = true;
            this.radioButton_perfume.Location = new System.Drawing.Point(12, 60);
            this.radioButton_perfume.Name = "radioButton_perfume";
            this.radioButton_perfume.Size = new System.Drawing.Size(64, 17);
            this.radioButton_perfume.TabIndex = 2;
            this.radioButton_perfume.Text = "Perfume";
            this.radioButton_perfume.UseVisualStyleBackColor = true;
            // 
            // textBox_preco
            // 
            this.textBox_preco.Location = new System.Drawing.Point(12, 108);
            this.textBox_preco.Name = "textBox_preco";
            this.textBox_preco.Size = new System.Drawing.Size(100, 20);
            this.textBox_preco.TabIndex = 3;
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(12, 201);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar.TabIndex = 4;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 308);
            this.Controls.Add(this.cmd_executar);
            this.Controls.Add(this.textBox_preco);
            this.Controls.Add(this.radioButton_perfume);
            this.Controls.Add(this.radioButton_martelo);
            this.Controls.Add(this.radioButton_leite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_leite;
        private System.Windows.Forms.RadioButton radioButton_martelo;
        private System.Windows.Forms.RadioButton radioButton_perfume;
        private System.Windows.Forms.TextBox textBox_preco;
        private System.Windows.Forms.Button cmd_executar;
    }
}

