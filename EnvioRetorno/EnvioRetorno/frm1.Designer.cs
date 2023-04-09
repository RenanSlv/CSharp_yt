namespace EnvioRetorno
{
    partial class frm1
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
            this.label_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(230, 333);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar.TabIndex = 0;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // label_txt
            // 
            this.label_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_txt.Location = new System.Drawing.Point(13, 13);
            this.label_txt.Name = "label_txt";
            this.label_txt.Size = new System.Drawing.Size(363, 65);
            this.label_txt.TabIndex = 1;
            this.label_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 368);
            this.Controls.Add(this.label_txt);
            this.Controls.Add(this.cmd_executar);
            this.Name = "frm1";
            this.Text = "FRM_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.Label label_txt;
    }
}

