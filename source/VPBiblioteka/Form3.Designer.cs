namespace VPBiblioteka
{
    partial class Form3
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
            this.lblKniga = new System.Windows.Forms.Label();
            this.tbKniga = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.btnNaracajKniga = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKniga
            // 
            this.lblKniga.AutoSize = true;
            this.lblKniga.Location = new System.Drawing.Point(12, 16);
            this.lblKniga.Name = "lblKniga";
            this.lblKniga.Size = new System.Drawing.Size(79, 13);
            this.lblKniga.TabIndex = 0;
            this.lblKniga.Text = "Име на книга:";
            // 
            // tbKniga
            // 
            this.tbKniga.Location = new System.Drawing.Point(99, 13);
            this.tbKniga.Name = "tbKniga";
            this.tbKniga.ReadOnly = true;
            this.tbKniga.Size = new System.Drawing.Size(249, 20);
            this.tbKniga.TabIndex = 1;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(15, 65);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(71, 13);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Вашето име:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вашето презиме:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Е-mail адреса:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Број за контакт \r\n(опционално):";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(18, 82);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(149, 20);
            this.tbIme.TabIndex = 6;
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(18, 137);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(149, 20);
            this.tbPrezime.TabIndex = 7;
            this.tbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrezime_KeyPress);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(173, 82);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(175, 20);
            this.tbMail.TabIndex = 8;
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(173, 137);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.Size = new System.Drawing.Size(175, 20);
            this.tbBroj.TabIndex = 9;
            this.tbBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBroj_KeyPress);
            // 
            // btnNaracajKniga
            // 
            this.btnNaracajKniga.Location = new System.Drawing.Point(18, 204);
            this.btnNaracajKniga.Name = "btnNaracajKniga";
            this.btnNaracajKniga.Size = new System.Drawing.Size(220, 23);
            this.btnNaracajKniga.TabIndex = 10;
            this.btnNaracajKniga.Text = "Нарачај книга";
            this.btnNaracajKniga.UseVisualStyleBackColor = true;
            this.btnNaracajKniga.Click += new System.EventHandler(this.btnNaracajKniga_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(244, 204);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(104, 23);
            this.btnOtkazi.TabIndex = 11;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 239);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnNaracajKniga);
            this.Controls.Add(this.tbBroj);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.tbKniga);
            this.Controls.Add(this.lblKniga);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKniga;
        private System.Windows.Forms.TextBox tbKniga;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.Button btnNaracajKniga;
        private System.Windows.Forms.Button btnOtkazi;
    }
}