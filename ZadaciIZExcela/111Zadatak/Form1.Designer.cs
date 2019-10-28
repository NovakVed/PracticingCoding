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
            this.rtbUnosPretipkaneRecenice.Location = new System.Drawing.Point(33, 207);
            this.rtbUnosPretipkaneRecenice.Name = "rtbUnosPretipkaneRecenice";
            this.rtbUnosPretipkaneRecenice.Size = new System.Drawing.Size(725, 111);
            this.rtbUnosPretipkaneRecenice.TabIndex = 1;
            this.rtbUnosPretipkaneRecenice.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbUnosPretipkaneRecenice);
            this.Controls.Add(this.rtbUnosRecenice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUnosRecenice;
        private System.Windows.Forms.RichTextBox rtbUnosPretipkaneRecenice;
    }
}

