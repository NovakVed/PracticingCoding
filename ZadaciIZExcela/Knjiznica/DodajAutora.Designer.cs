namespace Knjiznica
{
    partial class DodajAutora
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
            this.lbAutori = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAutori
            // 
            this.lbAutori.FormattingEnabled = true;
            this.lbAutori.Location = new System.Drawing.Point(12, 12);
            this.lbAutori.Name = "lbAutori";
            this.lbAutori.Size = new System.Drawing.Size(345, 368);
            this.lbAutori.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(13, 387);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(344, 51);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "DodajAutora";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // DodajAutora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lbAutori);
            this.Name = "DodajAutora";
            this.Text = "DodajAutora";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAutori;
        private System.Windows.Forms.Button btnDodaj;
    }
}