namespace Agenda1
{
    partial class frmPesquisaResultado
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
            this.cmd_novapesquisa = new System.Windows.Forms.Button();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.listBox_resultadoPSQ = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_novapesquisa
            // 
            this.cmd_novapesquisa.Location = new System.Drawing.Point(202, 201);
            this.cmd_novapesquisa.Name = "cmd_novapesquisa";
            this.cmd_novapesquisa.Size = new System.Drawing.Size(96, 34);
            this.cmd_novapesquisa.TabIndex = 0;
            this.cmd_novapesquisa.Text = "Nova Pesquisa";
            this.cmd_novapesquisa.UseVisualStyleBackColor = true;
            this.cmd_novapesquisa.Click += new System.EventHandler(this.cmd_novapesquisa_Click);
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(304, 201);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(96, 34);
            this.cmd_fechar.TabIndex = 1;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // listBox_resultadoPSQ
            // 
            this.listBox_resultadoPSQ.FormattingEnabled = true;
            this.listBox_resultadoPSQ.Location = new System.Drawing.Point(13, 13);
            this.listBox_resultadoPSQ.Name = "listBox_resultadoPSQ";
            this.listBox_resultadoPSQ.Size = new System.Drawing.Size(387, 173);
            this.listBox_resultadoPSQ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultados: 0";
            // 
            // frmPesquisaResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_resultadoPSQ);
            this.Controls.Add(this.cmd_fechar);
            this.Controls.Add(this.cmd_novapesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESULTADOS PESQUIDA";
            this.Load += new System.EventHandler(this.frmPesquisaResultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_novapesquisa;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.ListBox listBox_resultadoPSQ;
        private System.Windows.Forms.Label label1;
    }
}