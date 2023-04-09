namespace Cores
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
            this.caixa = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_red = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label_green = new System.Windows.Forms.Label();
            this.label_blue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.caixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // caixa
            // 
            this.caixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.caixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa.Location = new System.Drawing.Point(12, 12);
            this.caixa.Name = "caixa";
            this.caixa.Size = new System.Drawing.Size(329, 134);
            this.caixa.TabIndex = 0;
            this.caixa.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 182);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.Location = new System.Drawing.Point(13, 163);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(27, 13);
            this.label_red.TabIndex = 4;
            this.label_red.Text = "Red";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(12, 255);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(12, 319);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 6;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label_green
            // 
            this.label_green.AutoSize = true;
            this.label_green.Location = new System.Drawing.Point(12, 230);
            this.label_green.Name = "label_green";
            this.label_green.Size = new System.Drawing.Size(36, 13);
            this.label_green.TabIndex = 7;
            this.label_green.Text = "Green";
            // 
            // label_blue
            // 
            this.label_blue.AutoSize = true;
            this.label_blue.Location = new System.Drawing.Point(13, 303);
            this.label_blue.Name = "label_blue";
            this.label_blue.Size = new System.Drawing.Size(28, 13);
            this.label_blue.TabIndex = 8;
            this.label_blue.Text = "Blue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "RGB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_blue);
            this.Controls.Add(this.label_green);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label_red);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.caixa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.caixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox caixa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_red;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label_green;
        private System.Windows.Forms.Label label_blue;
        private System.Windows.Forms.Label label1;
    }
}

