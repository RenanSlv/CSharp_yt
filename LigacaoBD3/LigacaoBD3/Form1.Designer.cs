namespace LigacaoBD3
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
            this.list_dados = new System.Windows.Forms.ListBox();
            this.btn_executar = new System.Windows.Forms.Button();
            this.cmd_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_dados
            // 
            this.list_dados.FormattingEnabled = true;
            this.list_dados.Location = new System.Drawing.Point(13, 13);
            this.list_dados.Name = "list_dados";
            this.list_dados.Size = new System.Drawing.Size(434, 381);
            this.list_dados.TabIndex = 0;
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(454, 13);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(121, 59);
            this.btn_executar.TabIndex = 1;
            this.btn_executar.Text = "Select";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // cmd_insert
            // 
            this.cmd_insert.Location = new System.Drawing.Point(454, 78);
            this.cmd_insert.Name = "cmd_insert";
            this.cmd_insert.Size = new System.Drawing.Size(121, 59);
            this.cmd_insert.TabIndex = 2;
            this.cmd_insert.Text = "Insert";
            this.cmd_insert.UseVisualStyleBackColor = true;
            this.cmd_insert.Click += new System.EventHandler(this.cmd_insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 433);
            this.Controls.Add(this.cmd_insert);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.list_dados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_dados;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Button cmd_insert;
    }
}

