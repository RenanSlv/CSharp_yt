namespace Colecoes
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
            this.cmd_executar = new System.Windows.Forms.Button();
            this.listBox_resposta = new System.Windows.Forms.ListBox();
            this.cmd_list_inline = new System.Windows.Forms.Button();
            this.cmd_clear = new System.Windows.Forms.Button();
            this.cmd_hashset = new System.Windows.Forms.Button();
            this.cmd_dictionary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(433, 13);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(97, 37);
            this.cmd_executar.TabIndex = 0;
            this.cmd_executar.Text = "List";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // listBox_resposta
            // 
            this.listBox_resposta.FormattingEnabled = true;
            this.listBox_resposta.Location = new System.Drawing.Point(13, 13);
            this.listBox_resposta.Name = "listBox_resposta";
            this.listBox_resposta.Size = new System.Drawing.Size(414, 394);
            this.listBox_resposta.TabIndex = 1;
            // 
            // cmd_list_inline
            // 
            this.cmd_list_inline.Location = new System.Drawing.Point(433, 56);
            this.cmd_list_inline.Name = "cmd_list_inline";
            this.cmd_list_inline.Size = new System.Drawing.Size(97, 37);
            this.cmd_list_inline.TabIndex = 2;
            this.cmd_list_inline.Text = "List Inline";
            this.cmd_list_inline.UseVisualStyleBackColor = true;
            this.cmd_list_inline.Click += new System.EventHandler(this.cmd_list_inline_Click);
            // 
            // cmd_clear
            // 
            this.cmd_clear.Location = new System.Drawing.Point(433, 370);
            this.cmd_clear.Name = "cmd_clear";
            this.cmd_clear.Size = new System.Drawing.Size(97, 37);
            this.cmd_clear.TabIndex = 3;
            this.cmd_clear.Text = "Limpar";
            this.cmd_clear.UseVisualStyleBackColor = true;
            this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
            // 
            // cmd_hashset
            // 
            this.cmd_hashset.Location = new System.Drawing.Point(433, 99);
            this.cmd_hashset.Name = "cmd_hashset";
            this.cmd_hashset.Size = new System.Drawing.Size(97, 37);
            this.cmd_hashset.TabIndex = 4;
            this.cmd_hashset.Text = "HashSet";
            this.cmd_hashset.UseVisualStyleBackColor = true;
            this.cmd_hashset.Click += new System.EventHandler(this.cmd_hashset_Click);
            // 
            // cmd_dictionary
            // 
            this.cmd_dictionary.Location = new System.Drawing.Point(433, 142);
            this.cmd_dictionary.Name = "cmd_dictionary";
            this.cmd_dictionary.Size = new System.Drawing.Size(97, 37);
            this.cmd_dictionary.TabIndex = 5;
            this.cmd_dictionary.Text = "Dictionary";
            this.cmd_dictionary.UseVisualStyleBackColor = true;
            this.cmd_dictionary.Click += new System.EventHandler(this.cmd_dictionary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 422);
            this.Controls.Add(this.cmd_dictionary);
            this.Controls.Add(this.cmd_hashset);
            this.Controls.Add(this.cmd_clear);
            this.Controls.Add(this.cmd_list_inline);
            this.Controls.Add(this.listBox_resposta);
            this.Controls.Add(this.cmd_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_executar;
        private System.Windows.Forms.ListBox listBox_resposta;
        private System.Windows.Forms.Button cmd_list_inline;
        private System.Windows.Forms.Button cmd_clear;
        private System.Windows.Forms.Button cmd_hashset;
        private System.Windows.Forms.Button cmd_dictionary;
    }
}

