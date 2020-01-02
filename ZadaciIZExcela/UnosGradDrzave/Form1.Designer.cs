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
            this.label5 = new System.Windows.Forms.Label();
            this.dgwIspisDrzavaGradova = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIspisDrzavaGradova)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivDrzave
            // 
            this.txtNazivDrzave.Location = new System.Drawing.Point(23, 41);
            this.txtNazivDrzave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNazivDrzave.Name = "txtNazivDrzave";
            this.txtNazivDrzave.Size = new System.Drawing.Size(119, 20);
            this.txtNazivDrzave.TabIndex = 0;
            // 
            // txtBrojStanovnika
            // 
            this.txtBrojStanovnika.Location = new System.Drawing.Point(260, 76);
            this.txtBrojStanovnika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrojStanovnika.Name = "txtBrojStanovnika";
            this.txtBrojStanovnika.Size = new System.Drawing.Size(119, 20);
            this.txtBrojStanovnika.TabIndex = 1;
            // 
            // btnUnesiDrzavu
            // 
            this.btnUnesiDrzavu.Location = new System.Drawing.Point(52, 63);
            this.btnUnesiDrzavu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnesiDrzavu.Name = "btnUnesiDrzavu";
            this.btnUnesiDrzavu.Size = new System.Drawing.Size(88, 42);
            this.btnUnesiDrzavu.TabIndex = 2;
            this.btnUnesiDrzavu.Text = "Unesi drzavu";
            this.btnUnesiDrzavu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv drzave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj stanovnika";
            // 
            // cbOdabirDrzave
            // 
            this.cbOdabirDrzave.FormattingEnabled = true;
            this.cbOdabirDrzave.Location = new System.Drawing.Point(260, 112);
            this.cbOdabirDrzave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOdabirDrzave.Name = "cbOdabirDrzave";
            this.cbOdabirDrzave.Size = new System.Drawing.Size(119, 21);
            this.cbOdabirDrzave.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naziv grada";
            // 
            // btnUnosGrada
            // 
            this.btnUnosGrada.Location = new System.Drawing.Point(291, 136);
            this.btnUnosGrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUnosGrada.Name = "btnUnosGrada";
            this.btnUnosGrada.Size = new System.Drawing.Size(88, 42);
            this.btnUnosGrada.TabIndex = 7;
            this.btnUnosGrada.Text = "Unesi grad";
            this.btnUnosGrada.UseVisualStyleBackColor = true;
            // 
            // txtNazivGrada
            // 
            this.txtNazivGrada.Location = new System.Drawing.Point(262, 38);
            this.txtNazivGrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNazivGrada.Name = "txtNazivGrada";
            this.txtNazivGrada.Size = new System.Drawing.Size(119, 20);
            this.txtNazivGrada.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Drzava";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ispis";
            // 
            // dgwIspisDrzavaGradova
            // 
            this.dgwIspisDrzavaGradova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIspisDrzavaGradova.Location = new System.Drawing.Point(23, 207);
            this.dgwIspisDrzavaGradova.Name = "dgwIspisDrzavaGradova";
            this.dgwIspisDrzavaGradova.Size = new System.Drawing.Size(356, 150);
            this.dgwIspisDrzavaGradova.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 369);
            this.Controls.Add(this.dgwIspisDrzavaGradova);
            this.Controls.Add(this.label5);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwIspisDrzavaGradova)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwIspisDrzavaGradova;
    }
}

