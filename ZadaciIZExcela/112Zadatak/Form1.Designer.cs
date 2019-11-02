namespace _112Zadatak
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
            this.rtbInputedText = new System.Windows.Forms.RichTextBox();
            this.txtInputedChar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfChars = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRepetitionOfInputedChar = new System.Windows.Forms.Label();
            this.rtbReversedText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRepetitionOfWord = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInputedWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbInputedText
            // 
            this.rtbInputedText.Location = new System.Drawing.Point(42, 43);
            this.rtbInputedText.Margin = new System.Windows.Forms.Padding(2);
            this.rtbInputedText.Name = "rtbInputedText";
            this.rtbInputedText.Size = new System.Drawing.Size(500, 112);
            this.rtbInputedText.TabIndex = 0;
            this.rtbInputedText.Text = "";
            this.rtbInputedText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtInputedChar
            // 
            this.txtInputedChar.Location = new System.Drawing.Point(37, 341);
            this.txtInputedChar.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputedChar.Name = "txtInputedChar";
            this.txtInputedChar.Size = new System.Drawing.Size(76, 20);
            this.txtInputedChar.TabIndex = 1;
            this.txtInputedChar.TextChanged += new System.EventHandler(this.txtInputedChar_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj slova";
            // 
            // lblNumberOfChars
            // 
            this.lblNumberOfChars.AutoSize = true;
            this.lblNumberOfChars.Location = new System.Drawing.Point(107, 157);
            this.lblNumberOfChars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfChars.Name = "lblNumberOfChars";
            this.lblNumberOfChars.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOfChars.TabIndex = 3;
            this.lblNumberOfChars.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj ponavljanja zadanog slova";
            // 
            // lblRepetitionOfInputedChar
            // 
            this.lblRepetitionOfInputedChar.AutoSize = true;
            this.lblRepetitionOfInputedChar.Location = new System.Drawing.Point(218, 362);
            this.lblRepetitionOfInputedChar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepetitionOfInputedChar.Name = "lblRepetitionOfInputedChar";
            this.lblRepetitionOfInputedChar.Size = new System.Drawing.Size(13, 13);
            this.lblRepetitionOfInputedChar.TabIndex = 5;
            this.lblRepetitionOfInputedChar.Text = "0";
            // 
            // rtbReversedText
            // 
            this.rtbReversedText.Location = new System.Drawing.Point(42, 191);
            this.rtbReversedText.Margin = new System.Windows.Forms.Padding(2);
            this.rtbReversedText.Name = "rtbReversedText";
            this.rtbReversedText.ReadOnly = true;
            this.rtbReversedText.Size = new System.Drawing.Size(500, 112);
            this.rtbReversedText.TabIndex = 6;
            this.rtbReversedText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Odaberi slovo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Odaberi rijec";
            // 
            // lblRepetitionOfWord
            // 
            this.lblRepetitionOfWord.AutoSize = true;
            this.lblRepetitionOfWord.Location = new System.Drawing.Point(218, 435);
            this.lblRepetitionOfWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepetitionOfWord.Name = "lblRepetitionOfWord";
            this.lblRepetitionOfWord.Size = new System.Drawing.Size(13, 13);
            this.lblRepetitionOfWord.TabIndex = 10;
            this.lblRepetitionOfWord.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 435);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Broj ponavljanja zadane rijeci";
            // 
            // txtInputedWord
            // 
            this.txtInputedWord.Location = new System.Drawing.Point(37, 414);
            this.txtInputedWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputedWord.Name = "txtInputedWord";
            this.txtInputedWord.Size = new System.Drawing.Size(76, 20);
            this.txtInputedWord.TabIndex = 8;
            this.txtInputedWord.TextChanged += new System.EventHandler(this.txtInputedWord_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRepetitionOfWord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInputedWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbReversedText);
            this.Controls.Add(this.lblRepetitionOfInputedChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumberOfChars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputedChar);
            this.Controls.Add(this.rtbInputedText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInputedText;
        private System.Windows.Forms.TextBox txtInputedChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumberOfChars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRepetitionOfInputedChar;
        private System.Windows.Forms.RichTextBox rtbReversedText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRepetitionOfWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInputedWord;
    }
}

