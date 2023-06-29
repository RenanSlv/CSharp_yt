namespace ProjetoImagem2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_size = new System.Windows.Forms.Label();
            this.separadorHorizontal1 = new ProjetoImagem2.SeparadorHorizontal();
            this.SuspendLayout();
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(80, 74);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(35, 13);
            this.label_size.TabIndex = 0;
            this.label_size.Text = "label1";
            // 
            // separadorHorizontal1
            // 
            this.separadorHorizontal1.AlphaClaro = ((byte)(200));
            this.separadorHorizontal1.AlphaEcuro = ((byte)(100));
            this.separadorHorizontal1.BackColor = System.Drawing.Color.Transparent;
            this.separadorHorizontal1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separadorHorizontal1.BackgroundImage")));
            this.separadorHorizontal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.separadorHorizontal1.CorClara = System.Drawing.Color.White;
            this.separadorHorizontal1.CorEscura = System.Drawing.Color.Black;
            this.separadorHorizontal1.Location = new System.Drawing.Point(145, 147);
            this.separadorHorizontal1.Name = "separadorHorizontal1";
            this.separadorHorizontal1.Size = new System.Drawing.Size(211, 4);
            this.separadorHorizontal1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(508, 406);
            this.Controls.Add(this.separadorHorizontal1);
            this.Controls.Add(this.label_size);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_size;
        private SeparadorHorizontal separadorHorizontal1;
    }
}

