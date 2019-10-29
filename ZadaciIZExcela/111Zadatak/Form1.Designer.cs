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
            this.btnUpisi = new System.Windows.Forms.Button();
            this.btnZapocni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // rtbUnosRecenice
            // 
            this.rtbUnosRecenice.Location = new System.Drawing.Point(33, 37);
            this.rtbUnosRecenice.Name = "rtbUnosRecenice";
            this.rtbUnosRecenice.Size = new System.Drawing.Size(725, 96);
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
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(683, 139);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(75, 23);
            this.btnUpisi.TabIndex = 2;
            this.btnUpisi.Text = "Upiši";
            this.btnUpisi.UseVisualStyleBackColor = true;
            // 
            // btnZapocni
            // 
            this.btnZapocni.Location = new System.Drawing.Point(30, 215);
            this.btnZapocni.Name = "btnZapocni";
            this.btnZapocni.Size = new System.Drawing.Size(75, 23);
            this.btnZapocni.TabIndex = 3;
            this.btnZapocni.Text = "Započni";
            this.btnZapocni.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vrijeme";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZapocni);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.rtbUnosPretipkaneRecenice);
            this.Controls.Add(this.rtbUnosRecenice);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUnosRecenice;
        private System.Windows.Forms.RichTextBox rtbUnosPretipkaneRecenice;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Button btnZapocni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

