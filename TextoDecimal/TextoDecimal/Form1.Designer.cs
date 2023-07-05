namespace TextoDecimal
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
            this.cl_TextDecimal1 = new TextoDecimal.cl_TextDecimal();
            this.cl_TextDecimal2 = new TextoDecimal.cl_TextDecimal();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cl_TextDecimal1
            // 
            this.cl_TextDecimal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_TextDecimal1.Location = new System.Drawing.Point(58, 64);
            this.cl_TextDecimal1.Name = "cl_TextDecimal1";
            this.cl_TextDecimal1.NumeroCasasDecimais = 2;
            this.cl_TextDecimal1.PermitirDecimais = true;
            this.cl_TextDecimal1.SeparadorDecimal = TextoDecimal.cl_TextDecimal.EnumSeparador.Virgula;
            this.cl_TextDecimal1.Size = new System.Drawing.Size(161, 31);
            this.cl_TextDecimal1.TabIndex = 0;
            this.cl_TextDecimal1.ValorMaximo = 100D;
            this.cl_TextDecimal1.ValorMinimo = 0D;
            this.cl_TextDecimal1.ValorPorDefeito = 0D;
            // 
            // cl_TextDecimal2
            // 
            this.cl_TextDecimal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_TextDecimal2.Location = new System.Drawing.Point(58, 101);
            this.cl_TextDecimal2.Name = "cl_TextDecimal2";
            this.cl_TextDecimal2.NumeroCasasDecimais = 2;
            this.cl_TextDecimal2.PermitirDecimais = true;
            this.cl_TextDecimal2.SeparadorDecimal = TextoDecimal.cl_TextDecimal.EnumSeparador.Virgula;
            this.cl_TextDecimal2.Size = new System.Drawing.Size(161, 31);
            this.cl_TextDecimal2.TabIndex = 1;
            this.cl_TextDecimal2.ValorMaximo = 100D;
            this.cl_TextDecimal2.ValorMinimo = -100D;
            this.cl_TextDecimal2.ValorPorDefeito = 0D;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cl_TextDecimal2);
            this.Controls.Add(this.cl_TextDecimal1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cl_TextDecimal cl_TextDecimal1;
        private cl_TextDecimal cl_TextDecimal2;
        private System.Windows.Forms.Button button1;
    }
}

