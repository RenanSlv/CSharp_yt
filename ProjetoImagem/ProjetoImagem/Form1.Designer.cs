namespace ProjetoImagem
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
            this.components = new System.ComponentModel.Container();
            this.pic_test = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmd_test = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_test)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_test
            // 
            this.pic_test.BackColor = System.Drawing.SystemColors.Control;
            this.pic_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_test.Location = new System.Drawing.Point(12, 12);
            this.pic_test.Name = "pic_test";
            this.pic_test.Size = new System.Drawing.Size(600, 300);
            this.pic_test.TabIndex = 0;
            this.pic_test.TabStop = false;
            this.pic_test.Click += new System.EventHandler(this.pic_test_Click);
            this.pic_test.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_test_MouseClick);
            this.pic_test.MouseEnter += new System.EventHandler(this.pic_test_MouseEnter);
            this.pic_test.MouseLeave += new System.EventHandler(this.pic_test_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmd_test
            // 
            this.cmd_test.BackColor = System.Drawing.Color.Transparent;
            this.cmd_test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_test.Location = new System.Drawing.Point(12, 336);
            this.cmd_test.Name = "cmd_test";
            this.cmd_test.Size = new System.Drawing.Size(231, 122);
            this.cmd_test.TabIndex = 3;
            this.cmd_test.TabStop = false;
            this.cmd_test.EnabledChanged += new System.EventHandler(this.cmd_test_EnabledChanged);
            this.cmd_test.Click += new System.EventHandler(this.cmd_test_Click);
            this.cmd_test.MouseEnter += new System.EventHandler(this.cmd_test_MouseEnter);
            this.cmd_test.MouseLeave += new System.EventHandler(this.cmd_test_MouseLeave);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.EnabledChanged += new System.EventHandler(this.button3_EnabledChanged);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tempo
            // 
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 470);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmd_test);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_test);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_test)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox cmd_test;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer tempo;
    }
}

