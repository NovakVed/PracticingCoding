namespace BodoviNaKolegiju
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbPredmeti = new System.Windows.Forms.ListBox();
            this.lbAktivnosti = new System.Windows.Forms.ListBox();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.txtAktivnost = new System.Windows.Forms.TextBox();
            this.txtBodovi = new System.Windows.Forms.TextBox();
            this.txtOstvareniBodovi = new System.Windows.Forms.TextBox();
            this.btnDodajPredmet = new System.Windows.Forms.Button();
            this.btnDodajAktivnosti = new System.Windows.Forms.Button();
            this.btnSpremiBodove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvUkupniBodovi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkupniBodovi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Predmet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktivnosti";
            // 
            // lbPredmeti
            // 
            this.lbPredmeti.FormattingEnabled = true;
            this.lbPredmeti.ItemHeight = 16;
            this.lbPredmeti.Location = new System.Drawing.Point(13, 35);
            this.lbPredmeti.Margin = new System.Windows.Forms.Padding(4);
            this.lbPredmeti.Name = "lbPredmeti";
            this.lbPredmeti.Size = new System.Drawing.Size(245, 164);
            this.lbPredmeti.TabIndex = 2;
            this.lbPredmeti.SelectedIndexChanged += new System.EventHandler(this.lbPredmeti_SelectedIndexChanged);
            // 
            // lbAktivnosti
            // 
            this.lbAktivnosti.FormattingEnabled = true;
            this.lbAktivnosti.ItemHeight = 16;
            this.lbAktivnosti.Location = new System.Drawing.Point(276, 35);
            this.lbAktivnosti.Margin = new System.Windows.Forms.Padding(4);
            this.lbAktivnosti.Name = "lbAktivnosti";
            this.lbAktivnosti.Size = new System.Drawing.Size(245, 164);
            this.lbAktivnosti.TabIndex = 3;
            this.lbAktivnosti.SelectedIndexChanged += new System.EventHandler(this.lbAktivnosti_SelectedIndexChanged);
            // 
            // txtPredmet
            // 
            this.txtPredmet.Location = new System.Drawing.Point(13, 221);
            this.txtPredmet.Margin = new System.Windows.Forms.Padding(4);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(245, 22);
            this.txtPredmet.TabIndex = 4;
            // 
            // txtAktivnost
            // 
            this.txtAktivnost.Location = new System.Drawing.Point(276, 221);
            this.txtAktivnost.Margin = new System.Windows.Forms.Padding(4);
            this.txtAktivnost.Name = "txtAktivnost";
            this.txtAktivnost.Size = new System.Drawing.Size(173, 22);
            this.txtAktivnost.TabIndex = 5;
            // 
            // txtBodovi
            // 
            this.txtBodovi.Location = new System.Drawing.Point(459, 221);
            this.txtBodovi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBodovi.Name = "txtBodovi";
            this.txtBodovi.Size = new System.Drawing.Size(63, 22);
            this.txtBodovi.TabIndex = 6;
            // 
            // txtOstvareniBodovi
            // 
            this.txtOstvareniBodovi.Location = new System.Drawing.Point(533, 35);
            this.txtOstvareniBodovi.Margin = new System.Windows.Forms.Padding(4);
            this.txtOstvareniBodovi.Name = "txtOstvareniBodovi";
            this.txtOstvareniBodovi.Size = new System.Drawing.Size(240, 22);
            this.txtOstvareniBodovi.TabIndex = 7;
            // 
            // btnDodajPredmet
            // 
            this.btnDodajPredmet.Location = new System.Drawing.Point(13, 253);
            this.btnDodajPredmet.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajPredmet.Name = "btnDodajPredmet";
            this.btnDodajPredmet.Size = new System.Drawing.Size(247, 28);
            this.btnDodajPredmet.TabIndex = 8;
            this.btnDodajPredmet.Text = "Dodaj";
            this.btnDodajPredmet.UseVisualStyleBackColor = true;
            this.btnDodajPredmet.Click += new System.EventHandler(this.btnDodajPredmet_Click);
            // 
            // btnDodajAktivnosti
            // 
            this.btnDodajAktivnosti.Location = new System.Drawing.Point(276, 253);
            this.btnDodajAktivnosti.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajAktivnosti.Name = "btnDodajAktivnosti";
            this.btnDodajAktivnosti.Size = new System.Drawing.Size(247, 28);
            this.btnDodajAktivnosti.TabIndex = 9;
            this.btnDodajAktivnosti.Text = "Dodaj";
            this.btnDodajAktivnosti.UseVisualStyleBackColor = true;
            this.btnDodajAktivnosti.Click += new System.EventHandler(this.btnDodajAktivnosti_Click);
            // 
            // btnSpremiBodove
            // 
            this.btnSpremiBodove.Location = new System.Drawing.Point(533, 67);
            this.btnSpremiBodove.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremiBodove.Name = "btnSpremiBodove";
            this.btnSpremiBodove.Size = new System.Drawing.Size(247, 28);
            this.btnSpremiBodove.TabIndex = 10;
            this.btnSpremiBodove.Text = "Spremi";
            this.btnSpremiBodove.UseVisualStyleBackColor = true;
            this.btnSpremiBodove.Click += new System.EventHandler(this.btnSpremiBodove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bodovi za odabranu aktivnost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ukupni bodovi po predmetima";
            // 
            // dgvUkupniBodovi
            // 
            this.dgvUkupniBodovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUkupniBodovi.Location = new System.Drawing.Point(13, 318);
            this.dgvUkupniBodovi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUkupniBodovi.Name = "dgvUkupniBodovi";
            this.dgvUkupniBodovi.RowHeadersWidth = 51;
            this.dgvUkupniBodovi.Size = new System.Drawing.Size(904, 225);
            this.dgvUkupniBodovi.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 559);
            this.Controls.Add(this.dgvUkupniBodovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSpremiBodove);
            this.Controls.Add(this.btnDodajAktivnosti);
            this.Controls.Add(this.btnDodajPredmet);
            this.Controls.Add(this.txtOstvareniBodovi);
            this.Controls.Add(this.txtBodovi);
            this.Controls.Add(this.txtAktivnost);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.lbAktivnosti);
            this.Controls.Add(this.lbPredmeti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUkupniBodovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbPredmeti;
        private System.Windows.Forms.ListBox lbAktivnosti;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.TextBox txtAktivnost;
        private System.Windows.Forms.TextBox txtBodovi;
        private System.Windows.Forms.TextBox txtOstvareniBodovi;
        private System.Windows.Forms.Button btnDodajPredmet;
        private System.Windows.Forms.Button btnDodajAktivnosti;
        private System.Windows.Forms.Button btnSpremiBodove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvUkupniBodovi;
    }
}

