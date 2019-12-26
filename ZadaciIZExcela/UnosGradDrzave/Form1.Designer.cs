namespace UnosGradDrzave
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
            this.txtNazivDrzave = new System.Windows.Forms.TextBox();
            this.txtBrojStanovnika = new System.Windows.Forms.TextBox();
            this.btnUnesiDrzavu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOdabirDrzave = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnosGrada = new System.Windows.Forms.Button();
            this.txtNazivGrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNazivDrzave
            // 
            this.txtNazivDrzave.Location = new System.Drawing.Point(31, 50);
            this.txtNazivDrzave.Name = "txtNazivDrzave";
            this.txtNazivDrzave.Size = new System.Drawing.Size(157, 22);
            this.txtNazivDrzave.TabIndex = 0;
            // 
            // txtBrojStanovnika
            // 
            this.txtBrojStanovnika.Location = new System.Drawing.Point(346, 93);
            this.txtBrojStanovnika.Name = "txtBrojStanovnika";
            this.txtBrojStanovnika.Size = new System.Drawing.Size(157, 22);
            this.txtBrojStanovnika.TabIndex = 1;
            // 
            // btnUnesiDrzavu
            // 
            this.btnUnesiDrzavu.Location = new System.Drawing.Point(70, 78);
            this.btnUnesiDrzavu.Name = "btnUnesiDrzavu";
            this.btnUnesiDrzavu.Size = new System.Drawing.Size(118, 52);
            this.btnUnesiDrzavu.TabIndex = 2;
            this.btnUnesiDrzavu.Text = "Unesi drzavu";
            this.btnUnesiDrzavu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv drzave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj stanovnika";
            // 
            // cbOdabirDrzave
            // 
            this.cbOdabirDrzave.FormattingEnabled = true;
            this.cbOdabirDrzave.Location = new System.Drawing.Point(346, 138);
            this.cbOdabirDrzave.Name = "cbOdabirDrzave";
            this.cbOdabirDrzave.Size = new System.Drawing.Size(157, 24);
            this.cbOdabirDrzave.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naziv grada";
            // 
            // btnUnosGrada
            // 
            this.btnUnosGrada.Location = new System.Drawing.Point(388, 168);
            this.btnUnosGrada.Name = "btnUnosGrada";
            this.btnUnosGrada.Size = new System.Drawing.Size(118, 52);
            this.btnUnosGrada.TabIndex = 7;
            this.btnUnosGrada.Text = "Unesi grad";
            this.btnUnosGrada.UseVisualStyleBackColor = true;
            // 
            // txtNazivGrada
            // 
            this.txtNazivGrada.Location = new System.Drawing.Point(349, 47);
            this.txtNazivGrada.Name = "txtNazivGrada";
            this.txtNazivGrada.Size = new System.Drawing.Size(157, 22);
            this.txtNazivGrada.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Drzava";
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(31, 239);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(475, 194);
            this.txtIspis.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ispis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 454);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUnosGrada);
            this.Controls.Add(this.txtNazivGrada);
            this.Controls.Add(this.cbOdabirDrzave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnesiDrzavu);
            this.Controls.Add(this.txtBrojStanovnika);
            this.Controls.Add(this.txtNazivDrzave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivDrzave;
        private System.Windows.Forms.TextBox txtBrojStanovnika;
        private System.Windows.Forms.Button btnUnesiDrzavu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOdabirDrzave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnosGrada;
        private System.Windows.Forms.TextBox txtNazivGrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Label label5;
    }
}

