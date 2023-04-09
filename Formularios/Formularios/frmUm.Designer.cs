namespace Formularios
{
    partial class frmUm
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
            this.label_resultado = new System.Windows.Forms.Label();
            this.label_outra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_1
            // 
            this.cmd_1.Location = new System.Drawing.Point(303, 294);
            this.cmd_1.Name = "cmd_1";
            this.cmd_1.Size = new System.Drawing.Size(140, 79);
            this.cmd_1.TabIndex = 0;
            this.cmd_1.Text = "Fechar";
            this.cmd_1.UseVisualStyleBackColor = true;
            this.cmd_1.Click += new System.EventHandler(this.cmd_1_Click);
            // 
            // cmd_2
            // 
            this.cmd_2.Location = new System.Drawing.Point(163, 322);
            this.cmd_2.Name = "cmd_2";
            this.cmd_2.Size = new System.Drawing.Size(112, 51);
            this.cmd_2.TabIndex = 1;
            this.cmd_2.Text = "button2";
            this.cmd_2.UseVisualStyleBackColor = true;
            this.cmd_2.Click += new System.EventHandler(this.cmd_2_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(13, 13);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(33, 13);
            this.label_resultado.TabIndex = 2;
            this.label_resultado.Text = "nome";
            // 
            // label_outra
            // 
            this.label_outra.AutoSize = true;
            this.label_outra.Location = new System.Drawing.Point(12, 107);
            this.label_outra.Name = "label_outra";
            this.label_outra.Size = new System.Drawing.Size(33, 13);
            this.label_outra.TabIndex = 3;
            this.label_outra.Text = "Outra";
            this.label_outra.Click += new System.EventHandler(this.label_outra_Click);
            // 
            // frmUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 385);
            this.Controls.Add(this.label_outra);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.cmd_2);
            this.Controls.Add(this.cmd_1);
            this.Name = "frmUm";
            this.Text = "frmUm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_1;
        private System.Windows.Forms.Button cmd_2;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Label label_outra;
    }
}