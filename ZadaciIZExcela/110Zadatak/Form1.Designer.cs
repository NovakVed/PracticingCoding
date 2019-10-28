namespace _110Zadatak
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
            this.txtUnesiRijec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNajcesceSlovo = new System.Windows.Forms.TextBox();
            this.txtNajrijedeSlovo = new System.Windows.Forms.TextBox();
            this.txtNajcesciSamoglasnik = new System.Windows.Forms.TextBox();
            this.txtNajcesciSuglasnik = new System.Windows.Forms.TextBox();
            this.txtBrojSlova = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUnesiRijec
            // 
            this.txtUnesiRijec.Location = new System.Drawing.Point(109, 46);
            this.txtUnesiRijec.Name = "txtUnesiRijec";
            this.txtUnesiRijec.Size = new System.Drawing.Size(333, 22);
            this.txtUnesiRijec.TabIndex = 0;
            this.txtUnesiRijec.TextChanged += new System.EventHandler(this.txtUnesiRijec_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite riječ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBrojSlova);
            this.groupBox1.Controls.Add(this.txtNajcesciSuglasnik);
            this.groupBox1.Controls.Add(this.txtNajcesciSamoglasnik);
            this.groupBox1.Controls.Add(this.txtNajrijedeSlovo);
            this.groupBox1.Controls.Add(this.txtNajcesceSlovo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 263);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezultati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj slova: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Najčešće slovo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Najrjeđe slova: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Najčešći samoglasnik: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Najčešći suglasnik:";
            // 
            // txtNajcesceSlovo
            // 
            this.txtNajcesceSlovo.Location = new System.Drawing.Point(183, 96);
            this.txtNajcesceSlovo.Name = "txtNajcesceSlovo";
            this.txtNajcesceSlovo.Size = new System.Drawing.Size(133, 22);
            this.txtNajcesceSlovo.TabIndex = 3;
            // 
            // txtNajrijedeSlovo
            // 
            this.txtNajrijedeSlovo.Location = new System.Drawing.Point(183, 140);
            this.txtNajrijedeSlovo.Name = "txtNajrijedeSlovo";
            this.txtNajrijedeSlovo.Size = new System.Drawing.Size(133, 22);
            this.txtNajrijedeSlovo.TabIndex = 8;
            // 
            // txtNajcesciSamoglasnik
            // 
            this.txtNajcesciSamoglasnik.Location = new System.Drawing.Point(183, 185);
            this.txtNajcesciSamoglasnik.Name = "txtNajcesciSamoglasnik";
            this.txtNajcesciSamoglasnik.Size = new System.Drawing.Size(133, 22);
            this.txtNajcesciSamoglasnik.TabIndex = 9;
            // 
            // txtNajcesciSuglasnik
            // 
            this.txtNajcesciSuglasnik.Location = new System.Drawing.Point(183, 222);
            this.txtNajcesciSuglasnik.Name = "txtNajcesciSuglasnik";
            this.txtNajcesciSuglasnik.Size = new System.Drawing.Size(133, 22);
            this.txtNajcesciSuglasnik.TabIndex = 10;
            // 
            // txtBrojSlova
            // 
            this.txtBrojSlova.Location = new System.Drawing.Point(183, 54);
            this.txtBrojSlova.Name = "txtBrojSlova";
            this.txtBrojSlova.Size = new System.Drawing.Size(133, 22);
            this.txtBrojSlova.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnesiRijec);
            this.Name = "Form1";
            this.Text = "Broj slova";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnesiRijec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNajcesciSuglasnik;
        private System.Windows.Forms.TextBox txtNajcesciSamoglasnik;
        private System.Windows.Forms.TextBox txtNajrijedeSlovo;
        private System.Windows.Forms.TextBox txtNajcesceSlovo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojSlova;
    }
}

