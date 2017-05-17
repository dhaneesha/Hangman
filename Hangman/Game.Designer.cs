namespace Hangman
{
    partial class Game
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
            this.lblTest = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblTriedKeys = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.pctBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(9, 21);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(48, 13);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "Testing :";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(7, 237);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(114, 42);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "_ _ _ ";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 317);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblTriedKeys
            // 
            this.lblTriedKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTriedKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriedKeys.Location = new System.Drawing.Point(8, 75);
            this.lblTriedKeys.Name = "lblTriedKeys";
            this.lblTriedKeys.Size = new System.Drawing.Size(303, 162);
            this.lblTriedKeys.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tried Keys";
            // 
            // lblTest2
            // 
            this.lblTest2.AutoSize = true;
            this.lblTest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest2.Location = new System.Drawing.Point(174, 21);
            this.lblTest2.Name = "lblTest2";
            this.lblTest2.Size = new System.Drawing.Size(0, 20);
            this.lblTest2.TabIndex = 5;
            // 
            // pctBox
            // 
            this.pctBox.ErrorImage = null;
            this.pctBox.InitialImage = null;
            this.pctBox.Location = new System.Drawing.Point(348, 21);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(236, 258);
            this.pctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctBox.TabIndex = 6;
            this.pctBox.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 352);
            this.Controls.Add(this.pctBox);
            this.Controls.Add(this.lblTest2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTriedKeys);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblTest);
            this.KeyPreview = true;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblTriedKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.PictureBox pctBox;
    }
}