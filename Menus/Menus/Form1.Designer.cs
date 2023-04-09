namespace Menus
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
            this.menu_geral = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_new_project = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.proToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_combobox = new System.Windows.Forms.ToolStripComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_resultado = new System.Windows.Forms.Label();
            this.menu_geral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_geral
            // 
            this.menu_geral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.editToolStripMenuItem,
            this.menu_combobox});
            this.menu_geral.Location = new System.Drawing.Point(0, 0);
            this.menu_geral.Name = "menu_geral";
            this.menu_geral.Size = new System.Drawing.Size(745, 27);
            this.menu_geral.TabIndex = 0;
            this.menu_geral.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_new,
            this.menu_open,
            this.toolStripSeparator1,
            this.menu_exit});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(37, 23);
            this.menu_file.Text = "File";
            // 
            // menu_new
            // 
            this.menu_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_new_project,
            this.menu_new_file});
            this.menu_new.Name = "menu_new";
            this.menu_new.Size = new System.Drawing.Size(180, 22);
            this.menu_new.Text = "New";
            // 
            // menu_new_project
            // 
            this.menu_new_project.Name = "menu_new_project";
            this.menu_new_project.Size = new System.Drawing.Size(111, 22);
            this.menu_new_project.Text = "Project";
            // 
            // menu_new_file
            // 
            this.menu_new_file.Name = "menu_new_file";
            this.menu_new_file.Size = new System.Drawing.Size(111, 22);
            this.menu_new_file.Text = "File";
            // 
            // menu_open
            // 
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(180, 22);
            this.menu_open.Text = "Open";
            this.menu_open.Click += new System.EventHandler(this.menu_open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menu_exit.Size = new System.Drawing.Size(180, 22);
            this.menu_exit.Text = "Exit";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.proToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(124, 6);
            // 
            // proToolStripMenuItem
            // 
            this.proToolStripMenuItem.Name = "proToolStripMenuItem";
            this.proToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.proToolStripMenuItem.Text = "Properties";
            // 
            // menu_combobox
            // 
            this.menu_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menu_combobox.Name = "menu_combobox";
            this.menu_combobox.Size = new System.Drawing.Size(121, 23);
            this.menu_combobox.SelectedIndexChanged += new System.EventHandler(this.menu_combobox_SelectedIndexChanged);
            this.menu_combobox.Click += new System.EventHandler(this.menu_combobox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(341, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(47, 145);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(35, 13);
            this.label_resultado.TabIndex = 3;
            this.label_resultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 466);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menu_geral);
            this.MainMenuStrip = this.menu_geral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_geral.ResumeLayout(false);
            this.menu_geral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_geral;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem menu_new;
        private System.Windows.Forms.ToolStripMenuItem menu_open;
        private System.Windows.Forms.ToolStripMenuItem menu_new_project;
        private System.Windows.Forms.ToolStripMenuItem menu_new_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem proToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox menu_combobox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_resultado;
    }
}

