namespace ZadaciIZExcela
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
            this.components = new System.ComponentModel.Container();
            this.lbBoje = new System.Windows.Forms.ListBox();
            this.txtUnesenaBoja = new System.Windows.Forms.TextBox();
            this.btnUnesiBoju = new System.Windows.Forms.Button();
            this.btnPrikaziBoju = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbBoje
            // 
            this.lbBoje.FormattingEnabled = true;
            this.lbBoje.ItemHeight = 16;
            this.lbBoje.Location = new System.Drawing.Point(30, 114);
            this.lbBoje.Name = "lbBoje";
            this.lbBoje.Size = new System.Drawing.Size(120, 212);
            this.lbBoje.TabIndex = 0;
            // 
            // txtUnesenaBoja
            // 
            this.txtUnesenaBoja.Location = new System.Drawing.Point(30, 53);
            this.txtUnesenaBoja.Name = "txtUnesenaBoja";
            this.txtUnesenaBoja.Size = new System.Drawing.Size(100, 22);
            this.txtUnesenaBoja.TabIndex = 1;
            // 
            // btnUnesiBoju
            // 
            this.btnUnesiBoju.Location = new System.Drawing.Point(190, 51);
            this.btnUnesiBoju.Name = "btnUnesiBoju";
            this.btnUnesiBoju.Size = new System.Drawing.Size(75, 23);
            this.btnUnesiBoju.TabIndex = 2;
            this.btnUnesiBoju.Text = "Unesi";
            this.btnUnesiBoju.UseVisualStyleBackColor = true;
            this.btnUnesiBoju.Click += new System.EventHandler(this.btnUnesiBoju_Click);
            // 
            // btnPrikaziBoju
            // 
            this.btnPrikaziBoju.Location = new System.Drawing.Point(190, 303);
            this.btnPrikaziBoju.Name = "btnPrikaziBoju";
            this.btnPrikaziBoju.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaziBoju.TabIndex = 3;
            this.btnPrikaziBoju.Text = "Prikaži boju";
            this.btnPrikaziBoju.UseVisualStyleBackColor = true;
            this.btnPrikaziBoju.Click += new System.EventHandler(this.btnPrikaziBoju_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unesi boju";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unesene boje";;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikaziBoju);
            this.Controls.Add(this.btnUnesiBoju);
            this.Controls.Add(this.txtUnesenaBoja);
            this.Controls.Add(this.lbBoje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBoje;
        private System.Windows.Forms.TextBox txtUnesenaBoja;
        private System.Windows.Forms.Button btnUnesiBoju;
        private System.Windows.Forms.Button btnPrikaziBoju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

