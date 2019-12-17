namespace BodoviNaKolegijima
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
            this.lbKolegiji = new System.Windows.Forms.ListBox();
            this.lbAktivnosti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpremiKolegij = new System.Windows.Forms.TextBox();
            this.txtAktivnosti = new System.Windows.Forms.TextBox();
            this.txtOsvojeniBodoviAktivnosti = new System.Windows.Forms.TextBox();
            this.txtMaxBodoviAktivnosti = new System.Windows.Forms.TextBox();
            this.dgvPregled = new System.Windows.Forms.DataGridView();
            this.btnSpremiKolegij = new System.Windows.Forms.Button();
            this.btnSpremiAktivnost = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kolegiji";
            // 
            // lbKolegiji
            // 
            this.lbKolegiji.FormattingEnabled = true;
            this.lbKolegiji.ItemHeight = 16;
            this.lbKolegiji.Location = new System.Drawing.Point(45, 78);
            this.lbKolegiji.Name = "lbKolegiji";
            this.lbKolegiji.Size = new System.Drawing.Size(120, 132);
            this.lbKolegiji.TabIndex = 13;
            this.lbKolegiji.SelectedIndexChanged += new System.EventHandler(this.lbKolegiji_SelectedIndexChanged);
            // 
            // lbAktivnosti
            // 
            this.lbAktivnosti.FormattingEnabled = true;
            this.lbAktivnosti.ItemHeight = 16;
            this.lbAktivnosti.Location = new System.Drawing.Point(259, 78);
            this.lbAktivnosti.Name = "lbAktivnosti";
            this.lbAktivnosti.Size = new System.Drawing.Size(120, 132);
            this.lbAktivnosti.TabIndex = 14;
            this.lbAktivnosti.SelectedIndexChanged += new System.EventHandler(this.lbAktivnosti_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Predmeti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Osvojeni bodovi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ukupan pregled";
            // 
            // txtSpremiKolegij
            // 
            this.txtSpremiKolegij.Location = new System.Drawing.Point(45, 227);
            this.txtSpremiKolegij.Name = "txtSpremiKolegij";
            this.txtSpremiKolegij.Size = new System.Drawing.Size(100, 22);
            this.txtSpremiKolegij.TabIndex = 18;
            // 
            // txtAktivnosti
            // 
            this.txtAktivnosti.Location = new System.Drawing.Point(259, 227);
            this.txtAktivnosti.Name = "txtAktivnosti";
            this.txtAktivnosti.Size = new System.Drawing.Size(100, 22);
            this.txtAktivnosti.TabIndex = 19;
            // 
            // txtOsvojeniBodoviAktivnosti
            // 
            this.txtOsvojeniBodoviAktivnosti.Location = new System.Drawing.Point(473, 136);
            this.txtOsvojeniBodoviAktivnosti.Name = "txtOsvojeniBodoviAktivnosti";
            this.txtOsvojeniBodoviAktivnosti.Size = new System.Drawing.Size(100, 22);
            this.txtOsvojeniBodoviAktivnosti.TabIndex = 20;
            // 
            // txtMaxBodoviAktivnosti
            // 
            this.txtMaxBodoviAktivnosti.Location = new System.Drawing.Point(375, 227);
            this.txtMaxBodoviAktivnosti.Name = "txtMaxBodoviAktivnosti";
            this.txtMaxBodoviAktivnosti.Size = new System.Drawing.Size(39, 22);
            this.txtMaxBodoviAktivnosti.TabIndex = 21;
            // 
            // dgvPregled
            // 
            this.dgvPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregled.Location = new System.Drawing.Point(32, 336);
            this.dgvPregled.Name = "dgvPregled";
            this.dgvPregled.RowHeadersWidth = 51;
            this.dgvPregled.RowTemplate.Height = 24;
            this.dgvPregled.Size = new System.Drawing.Size(645, 150);
            this.dgvPregled.TabIndex = 22;
            // 
            // btnSpremiKolegij
            // 
            this.btnSpremiKolegij.Location = new System.Drawing.Point(45, 256);
            this.btnSpremiKolegij.Name = "btnSpremiKolegij";
            this.btnSpremiKolegij.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiKolegij.TabIndex = 23;
            this.btnSpremiKolegij.Text = "Spremi";
            this.btnSpremiKolegij.UseVisualStyleBackColor = true;
            this.btnSpremiKolegij.Click += new System.EventHandler(this.btnSpremiKolegij_Click);
            // 
            // btnSpremiAktivnost
            // 
            this.btnSpremiAktivnost.Location = new System.Drawing.Point(259, 256);
            this.btnSpremiAktivnost.Name = "btnSpremiAktivnost";
            this.btnSpremiAktivnost.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiAktivnost.TabIndex = 24;
            this.btnSpremiAktivnost.Text = "Spremi";
            this.btnSpremiAktivnost.UseVisualStyleBackColor = true;
            this.btnSpremiAktivnost.Click += new System.EventHandler(this.btnSpremiAktivnost_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(473, 164);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 25;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnSpremiAktivnost);
            this.Controls.Add(this.btnSpremiKolegij);
            this.Controls.Add(this.dgvPregled);
            this.Controls.Add(this.txtMaxBodoviAktivnosti);
            this.Controls.Add(this.txtOsvojeniBodoviAktivnosti);
            this.Controls.Add(this.txtAktivnosti);
            this.Controls.Add(this.txtSpremiKolegij);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAktivnosti);
            this.Controls.Add(this.lbKolegiji);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKolegiji;
        private System.Windows.Forms.ListBox lbAktivnosti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpremiKolegij;
        private System.Windows.Forms.TextBox txtAktivnosti;
        private System.Windows.Forms.TextBox txtOsvojeniBodoviAktivnosti;
        private System.Windows.Forms.TextBox txtMaxBodoviAktivnosti;
        private System.Windows.Forms.DataGridView dgvPregled;
        private System.Windows.Forms.Button btnSpremiKolegij;
        private System.Windows.Forms.Button btnSpremiAktivnost;
        private System.Windows.Forms.Button btnSpremi;
    }
}

