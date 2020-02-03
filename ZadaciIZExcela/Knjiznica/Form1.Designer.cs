namespace Knjiznica
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.btnIzbrisiOdabranogAutora = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAutori = new System.Windows.Forms.ListBox();
            this.txtIzdanjeKnjige = new System.Windows.Forms.TextBox();
            this.txtGodinaKnjige = new System.Windows.Forms.TextBox();
            this.txtNazivKnjige = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtbPretragaAutoraIKnjige = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraziAutoreIKnjige = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajAutora = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajKnjigu);
            this.groupBox2.Controls.Add(this.btnIzbrisiOdabranogAutora);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbAutori);
            this.groupBox2.Controls.Add(this.txtIzdanjeKnjige);
            this.groupBox2.Controls.Add(this.txtGodinaKnjige);
            this.groupBox2.Controls.Add(this.txtNazivKnjige);
            this.groupBox2.Location = new System.Drawing.Point(569, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Knjige";
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.Location = new System.Drawing.Point(6, 355);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(393, 65);
            this.btnDodajKnjigu.TabIndex = 12;
            this.btnDodajKnjigu.Text = "Dodaj knjigu";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiOdabranogAutora
            // 
            this.btnIzbrisiOdabranogAutora.Location = new System.Drawing.Point(271, 326);
            this.btnIzbrisiOdabranogAutora.Name = "btnIzbrisiOdabranogAutora";
            this.btnIzbrisiOdabranogAutora.Size = new System.Drawing.Size(107, 23);
            this.btnIzbrisiOdabranogAutora.TabIndex = 11;
            this.btnIzbrisiOdabranogAutora.Text = "Izbrisi autora";
            this.btnIzbrisiOdabranogAutora.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Autori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Izdanje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Godina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Naziv";
            // 
            // lbAutori
            // 
            this.lbAutori.FormattingEnabled = true;
            this.lbAutori.Location = new System.Drawing.Point(70, 137);
            this.lbAutori.Name = "lbAutori";
            this.lbAutori.Size = new System.Drawing.Size(184, 212);
            this.lbAutori.TabIndex = 4;
            // 
            // txtIzdanjeKnjige
            // 
            this.txtIzdanjeKnjige.Location = new System.Drawing.Point(70, 110);
            this.txtIzdanjeKnjige.Name = "txtIzdanjeKnjige";
            this.txtIzdanjeKnjige.Size = new System.Drawing.Size(184, 20);
            this.txtIzdanjeKnjige.TabIndex = 3;
            // 
            // txtGodinaKnjige
            // 
            this.txtGodinaKnjige.Location = new System.Drawing.Point(70, 75);
            this.txtGodinaKnjige.Name = "txtGodinaKnjige";
            this.txtGodinaKnjige.Size = new System.Drawing.Size(184, 20);
            this.txtGodinaKnjige.TabIndex = 2;
            // 
            // txtNazivKnjige
            // 
            this.txtNazivKnjige.Location = new System.Drawing.Point(70, 35);
            this.txtNazivKnjige.Name = "txtNazivKnjige";
            this.txtNazivKnjige.Size = new System.Drawing.Size(184, 20);
            this.txtNazivKnjige.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtbPretragaAutoraIKnjige);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtPretraziAutoreIKnjige);
            this.groupBox3.Location = new System.Drawing.Point(12, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 232);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretraga";
            // 
            // rtbPretragaAutoraIKnjige
            // 
            this.rtbPretragaAutoraIKnjige.Location = new System.Drawing.Point(115, 75);
            this.rtbPretragaAutoraIKnjige.Name = "rtbPretragaAutoraIKnjige";
            this.rtbPretragaAutoraIKnjige.Size = new System.Drawing.Size(321, 151);
            this.rtbPretragaAutoraIKnjige.TabIndex = 4;
            this.rtbPretragaAutoraIKnjige.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "btnPretrazi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pretrazi:";
            // 
            // txtPretraziAutoreIKnjige
            // 
            this.txtPretraziAutoreIKnjige.Location = new System.Drawing.Point(115, 19);
            this.txtPretraziAutoreIKnjige.Name = "txtPretraziAutoreIKnjige";
            this.txtPretraziAutoreIKnjige.Size = new System.Drawing.Size(321, 20);
            this.txtPretraziAutoreIKnjige.TabIndex = 0;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(115, 35);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(184, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(115, 75);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(184, 20);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajAutora);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autori";
            // 
            // btnDodajAutora
            // 
            this.btnDodajAutora.Location = new System.Drawing.Point(330, 35);
            this.btnDodajAutora.Name = "btnDodajAutora";
            this.btnDodajAutora.Size = new System.Drawing.Size(212, 95);
            this.btnDodajAutora.TabIndex = 6;
            this.btnDodajAutora.Text = "Dodaj autora";
            this.btnDodajAutora.UseVisualStyleBackColor = true;
            this.btnDodajAutora.Click += new System.EventHandler(this.btnDodajAutora_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbAutori;
        private System.Windows.Forms.TextBox txtIzdanjeKnjige;
        private System.Windows.Forms.TextBox txtGodinaKnjige;
        private System.Windows.Forms.TextBox txtNazivKnjige;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.Button btnIzbrisiOdabranogAutora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraziAutoreIKnjige;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbPretragaAutoraIKnjige;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodajAutora;
    }
}

