namespace Hangman
{
    partial class WordManager
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
            this.lstBoxWords = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.lstBoxWordLibrary = new System.Windows.Forms.ListBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnAddLib = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxWords
            // 
            this.lstBoxWords.FormattingEnabled = true;
            this.lstBoxWords.Location = new System.Drawing.Point(161, 12);
            this.lstBoxWords.Name = "lstBoxWords";
            this.lstBoxWords.Size = new System.Drawing.Size(115, 147);
            this.lstBoxWords.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 181);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(161, 228);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(100, 35);
            this.btnAddWord.TabIndex = 2;
            this.btnAddWord.Text = "Add Word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // lstBoxWordLibrary
            // 
            this.lstBoxWordLibrary.FormattingEnabled = true;
            this.lstBoxWordLibrary.Location = new System.Drawing.Point(12, 12);
            this.lstBoxWordLibrary.Name = "lstBoxWordLibrary";
            this.lstBoxWordLibrary.Size = new System.Drawing.Size(115, 147);
            this.lstBoxWordLibrary.TabIndex = 3;
            this.lstBoxWordLibrary.SelectedValueChanged += new System.EventHandler(this.lstBoxWordLibrary_SelectedValueChanged);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(161, 184);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(100, 20);
            this.txtWord.TabIndex = 4;
            this.txtWord.Text = "Enter Word Here";
            this.txtWord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtWord_MouseClick);
            // 
            // btnAddLib
            // 
            this.btnAddLib.Location = new System.Drawing.Point(12, 228);
            this.btnAddLib.Name = "btnAddLib";
            this.btnAddLib.Size = new System.Drawing.Size(100, 35);
            this.btnAddLib.TabIndex = 5;
            this.btnAddLib.Text = "AddLibrary";
            this.btnAddLib.UseVisualStyleBackColor = true;
            this.btnAddLib.Click += new System.EventHandler(this.btnAddLib_Click);
            // 
            // WordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 321);
            this.Controls.Add(this.btnAddLib);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lstBoxWordLibrary);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstBoxWords);
            this.Name = "WordManager";
            this.Text = "WordManager";
            this.Load += new System.EventHandler(this.WordManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxWords;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.ListBox lstBoxWordLibrary;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnAddLib;
    }
}