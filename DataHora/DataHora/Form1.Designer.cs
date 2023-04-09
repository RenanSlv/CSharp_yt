namespace DataHora
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
            this.textBox_dia = new System.Windows.Forms.TextBox();
            this.textBox_mes = new System.Windows.Forms.TextBox();
            this.textBox_ano = new System.Windows.Forms.TextBox();
            this.label_dia = new System.Windows.Forms.Label();
            this.label_mes = new System.Windows.Forms.Label();
            this.Ano = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(146, 169);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar.TabIndex = 0;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_resultado.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_resultado.Location = new System.Drawing.Point(12, 195);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(209, 100);
            this.label_resultado.TabIndex = 1;
            this.label_resultado.Text = "label1";
            // 
            // textBox_dia
            // 
            this.textBox_dia.Location = new System.Drawing.Point(13, 62);
            this.textBox_dia.Name = "textBox_dia";
            this.textBox_dia.Size = new System.Drawing.Size(100, 20);
            this.textBox_dia.TabIndex = 2;
            // 
            // textBox_mes
            // 
            this.textBox_mes.Location = new System.Drawing.Point(12, 109);
            this.textBox_mes.Name = "textBox_mes";
            this.textBox_mes.Size = new System.Drawing.Size(100, 20);
            this.textBox_mes.TabIndex = 3;
            // 
            // textBox_ano
            // 
            this.textBox_ano.Location = new System.Drawing.Point(13, 156);
            this.textBox_ano.Name = "textBox_ano";
            this.textBox_ano.Size = new System.Drawing.Size(100, 20);
            this.textBox_ano.TabIndex = 4;
            // 
            // label_dia
            // 
            this.label_dia.AutoSize = true;
            this.label_dia.Location = new System.Drawing.Point(13, 43);
            this.label_dia.Name = "label_dia";
            this.label_dia.Size = new System.Drawing.Size(23, 13);
            this.label_dia.TabIndex = 5;
            this.label_dia.Text = "Dia";
            // 
            // label_mes
            // 
            this.label_mes.AutoSize = true;
            this.label_mes.Location = new System.Drawing.Point(13, 93);
            this.label_mes.Name = "label_mes";
            this.label_mes.Size = new System.Drawing.Size(27, 13);
            this.label_mes.TabIndex = 6;
            this.label_mes.Text = "Mes";
            // 
            // Ano
            // 
            this.Ano.AutoSize = true;
            this.Ano.Location = new System.Drawing.Point(13, 140);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(26, 13);
            this.Ano.TabIndex = 7;
            this.Ano.Text = "Ano";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 319);
            this.Controls.Add(this.Ano);
            this.Controls.Add(this.label_mes);
            this.Controls.Add(this.label_dia);
            this.Controls.Add(this.textBox_ano);
            this.Controls.Add(this.textBox_mes);
            this.Controls.Add(this.textBox_dia);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.cmd_executar);
            this.Name = "Form1";
            this.Text = "Saber dia do nascimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox textBox_dia;
        private System.Windows.Forms.TextBox textBox_mes;
        private System.Windows.Forms.TextBox textBox_ano;
        private System.Windows.Forms.Label label_dia;
        private System.Windows.Forms.Label label_mes;
        private System.Windows.Forms.Label Ano;
    }
}

