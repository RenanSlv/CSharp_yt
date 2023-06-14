namespace AgendaSQL1
{
    partial class frmResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultados));
            this.cmd_sair = new System.Windows.Forms.Button();
            this.data_resultados = new System.Windows.Forms.DataGridView();
            this.label_resultados = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_vertudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(504, 342);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(75, 23);
            this.cmd_sair.TabIndex = 0;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // data_resultados
            // 
            this.data_resultados.AllowUserToAddRows = false;
            this.data_resultados.AllowUserToDeleteRows = false;
            this.data_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_resultados.Location = new System.Drawing.Point(12, 12);
            this.data_resultados.MultiSelect = false;
            this.data_resultados.Name = "data_resultados";
            this.data_resultados.ReadOnly = true;
            this.data_resultados.RowHeadersVisible = false;
            this.data_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_resultados.Size = new System.Drawing.Size(567, 324);
            this.data_resultados.TabIndex = 1;
            this.data_resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_resultados_CellClick);
            // 
            // label_resultados
            // 
            this.label_resultados.AutoSize = true;
            this.label_resultados.Location = new System.Drawing.Point(13, 343);
            this.label_resultados.Name = "label_resultados";
            this.label_resultados.Size = new System.Drawing.Size(35, 13);
            this.label_resultados.TabIndex = 2;
            this.label_resultados.Text = "label1";
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(423, 342);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(75, 23);
            this.cmd_apagar.TabIndex = 3;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Location = new System.Drawing.Point(342, 342);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(75, 23);
            this.cmd_editar.TabIndex = 4;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // cmd_vertudo
            // 
            this.cmd_vertudo.Location = new System.Drawing.Point(261, 342);
            this.cmd_vertudo.Name = "cmd_vertudo";
            this.cmd_vertudo.Size = new System.Drawing.Size(75, 23);
            this.cmd_vertudo.TabIndex = 5;
            this.cmd_vertudo.Text = "Ver Tudo";
            this.cmd_vertudo.UseVisualStyleBackColor = true;
            this.cmd_vertudo.Click += new System.EventHandler(this.cmd_vertudo_Click);
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 377);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_vertudo);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_resultados);
            this.Controls.Add(this.data_resultados);
            this.Controls.Add(this.cmd_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResultados";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.DataGridView data_resultados;
        private System.Windows.Forms.Label label_resultados;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Button cmd_vertudo;
    }
}