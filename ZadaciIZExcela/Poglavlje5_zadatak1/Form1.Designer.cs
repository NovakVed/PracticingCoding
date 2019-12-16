namespace Poglavlje5_zadatak1
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
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAutori = new System.Windows.Forms.DataGridView();
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezimeAutora = new System.Windows.Forms.TextBox();
            this.txtImeAutora = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodajAutora = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazivKnjige = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(62, 43);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(235, 22);
            this.txtPretrazi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretraži";
            // 
            // dgvAutori
            // 
            this.dgvAutori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutori.Location = new System.Drawing.Point(26, 138);
            this.dgvAutori.Name = "dgvAutori";
            this.dgvAutori.RowHeadersWidth = 51;
            this.dgvAutori.RowTemplate.Height = 24;
            this.dgvAutori.Size = new System.Drawing.Size(351, 150);
            this.dgvAutori.TabIndex = 2;
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Location = new System.Drawing.Point(24, 26);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.RowHeadersWidth = 51;
            this.dgvKnjige.RowTemplate.Height = 24;
            this.dgvKnjige.Size = new System.Drawing.Size(339, 150);
            this.dgvKnjige.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrezimeAutora);
            this.groupBox1.Controls.Add(this.txtImeAutora);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 326);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // txtPrezimeAutora
            // 
            this.txtPrezimeAutora.Location = new System.Drawing.Point(104, 251);
            this.txtPrezimeAutora.Name = "txtPrezimeAutora";
            this.txtPrezimeAutora.Size = new System.Drawing.Size(155, 22);
            this.txtPrezimeAutora.TabIndex = 1;
            // 
            // txtImeAutora
            // 
            this.txtImeAutora.Location = new System.Drawing.Point(104, 209);
            this.txtImeAutora.Name = "txtImeAutora";
            this.txtImeAutora.Size = new System.Drawing.Size(155, 22);
            this.txtImeAutora.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNazivKnjige);
            this.groupBox2.Controls.Add(this.dgvKnjige);
            this.groupBox2.Controls.Add(this.btnDodajKnjigu);
            this.groupBox2.Location = new System.Drawing.Point(409, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 326);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Knjige";
            // 
            // btnDodajAutora
            // 
            this.btnDodajAutora.Location = new System.Drawing.Point(302, 400);
            this.btnDodajAutora.Name = "btnDodajAutora";
            this.btnDodajAutora.Size = new System.Drawing.Size(75, 23);
            this.btnDodajAutora.TabIndex = 6;
            this.btnDodajAutora.Text = "Dodaj";
            this.btnDodajAutora.UseVisualStyleBackColor = true;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(330, 41);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 7;
            this.btnPretrazi.Text = "Search";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.Location = new System.Drawing.Point(288, 288);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKnjigu.TabIndex = 8;
            this.btnDodajKnjigu.Text = "Dodaj";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Naziv knjige";
            // 
            // txtNazivKnjige
            // 
            this.txtNazivKnjige.Location = new System.Drawing.Point(139, 251);
            this.txtNazivKnjige.Name = "txtNazivKnjige";
            this.txtNazivKnjige.Size = new System.Drawing.Size(155, 22);
            this.txtNazivKnjige.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnDodajAutora);
            this.Controls.Add(this.dgvAutori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAutori;
        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezimeAutora;
        private System.Windows.Forms.TextBox txtImeAutora;
        private System.Windows.Forms.Button btnDodajAutora;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazivKnjige;
        private System.Windows.Forms.Button btnDodajKnjigu;
    }
}

