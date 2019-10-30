namespace _111Zadatak
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
            this.rtbUnosRecenice = new System.Windows.Forms.RichTextBox();
            this.rtbUnosPretipkaneRecenice = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUkupnoVrijeme = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBrojZnakovaUSekundi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbUnosRecenice
            // 
            this.rtbUnosRecenice.Location = new System.Drawing.Point(33, 37);
            this.rtbUnosRecenice.Name = "rtbUnosRecenice";
            this.rtbUnosRecenice.Size = new System.Drawing.Size(725, 129);
            this.rtbUnosRecenice.TabIndex = 0;
            this.rtbUnosRecenice.Text = "";
            // 
            // rtbUnosPretipkaneRecenice
            // 
            this.rtbUnosPretipkaneRecenice.Location = new System.Drawing.Point(30, 244);
            this.rtbUnosPretipkaneRecenice.Name = "rtbUnosPretipkaneRecenice";
            this.rtbUnosPretipkaneRecenice.Size = new System.Drawing.Size(725, 111);
            this.rtbUnosPretipkaneRecenice.TabIndex = 1;
            this.rtbUnosPretipkaneRecenice.Text = "";
            this.rtbUnosPretipkaneRecenice.TextChanged += new System.EventHandler(this.rtbUnosPretipkaneRecenice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vrijeme";
            // 
            // lblUkupnoVrijeme
            // 
            this.lblUkupnoVrijeme.AutoSize = true;
            this.lblUkupnoVrijeme.Location = new System.Drawing.Point(218, 362);
            this.lblUkupnoVrijeme.Name = "lblUkupnoVrijeme";
            this.lblUkupnoVrijeme.Size = new System.Drawing.Size(16, 17);
            this.lblUkupnoVrijeme.TabIndex = 5;
            this.lblUkupnoVrijeme.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj znakova u sekundi";
            // 
            // lblBrojZnakovaUSekundi
            // 
            this.lblBrojZnakovaUSekundi.AutoSize = true;
            this.lblBrojZnakovaUSekundi.Location = new System.Drawing.Point(218, 390);
            this.lblBrojZnakovaUSekundi.Name = "lblBrojZnakovaUSekundi";
            this.lblBrojZnakovaUSekundi.Size = new System.Drawing.Size(16, 17);
            this.lblBrojZnakovaUSekundi.TabIndex = 8;
            this.lblBrojZnakovaUSekundi.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(22, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 223);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Započni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "sekundi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "sekundi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBrojZnakovaUSekundi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUkupnoVrijeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbUnosPretipkaneRecenice);
            this.Controls.Add(this.rtbUnosRecenice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUnosRecenice;
        private System.Windows.Forms.RichTextBox rtbUnosPretipkaneRecenice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUkupnoVrijeme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBrojZnakovaUSekundi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

