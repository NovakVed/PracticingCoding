namespace _113Zadatak
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnInputList = new System.Windows.Forms.Button();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.btnSortList = new System.Windows.Forms.Button();
            this.btnOriginalList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite broj";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(122, 30);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // btnInputList
            // 
            this.btnInputList.Location = new System.Drawing.Point(259, 63);
            this.btnInputList.Name = "btnInputList";
            this.btnInputList.Size = new System.Drawing.Size(75, 23);
            this.btnInputList.TabIndex = 2;
            this.btnInputList.Text = "Unesi";
            this.btnInputList.UseVisualStyleBackColor = true;
            this.btnInputList.Click += new System.EventHandler(this.btnInputList_Click);
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.Location = new System.Drawing.Point(43, 152);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(201, 160);
            this.lbNumbers.TabIndex = 3;
            // 
            // btnSortList
            // 
            this.btnSortList.Location = new System.Drawing.Point(287, 152);
            this.btnSortList.Name = "btnSortList";
            this.btnSortList.Size = new System.Drawing.Size(75, 23);
            this.btnSortList.TabIndex = 4;
            this.btnSortList.Text = "Sortiraj";
            this.btnSortList.UseVisualStyleBackColor = true;
            this.btnSortList.Click += new System.EventHandler(this.btnSortList_Click);
            // 
            // btnOriginalList
            // 
            this.btnOriginalList.Location = new System.Drawing.Point(287, 181);
            this.btnOriginalList.Name = "btnOriginalList";
            this.btnOriginalList.Size = new System.Drawing.Size(75, 23);
            this.btnOriginalList.TabIndex = 5;
            this.btnOriginalList.Text = "Originalni";
            this.btnOriginalList.UseVisualStyleBackColor = true;
            this.btnOriginalList.Click += new System.EventHandler(this.btnOriginalList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInputList);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 332);
            this.Controls.Add(this.btnOriginalList);
            this.Controls.Add(this.btnSortList);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnInputList;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.Button btnSortList;
        private System.Windows.Forms.Button btnOriginalList;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

