namespace VPBiblioteka
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
            this.lbKnigi = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPubHouse = new System.Windows.Forms.TextBox();
            this.tbPubYear = new System.Windows.Forms.TextBox();
            this.rtbSummary = new System.Windows.Forms.RichTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHorror = new System.Windows.Forms.CheckBox();
            this.cbMystery = new System.Windows.Forms.CheckBox();
            this.cbThriller = new System.Windows.Forms.CheckBox();
            this.cbFantasy = new System.Windows.Forms.CheckBox();
            this.cbDrama = new System.Windows.Forms.CheckBox();
            this.cbRomance = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKnigi
            // 
            this.lbKnigi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbKnigi.FormattingEnabled = true;
            this.lbKnigi.Location = new System.Drawing.Point(18, 39);
            this.lbKnigi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbKnigi.Name = "lbKnigi";
            this.lbKnigi.Size = new System.Drawing.Size(262, 290);
            this.lbKnigi.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbSurname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPubHouse);
            this.panel1.Controls.Add(this.tbPubYear);
            this.panel1.Controls.Add(this.rtbSummary);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Location = new System.Drawing.Point(296, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 405);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Презиме на авторот";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(25, 57);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.ReadOnly = true;
            this.tbSurname.Size = new System.Drawing.Size(142, 20);
            this.tbSurname.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кратка содржина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Издавачка куќа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Година на издавање";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Име на авторот";
            // 
            // tbPubHouse
            // 
            this.tbPubHouse.Location = new System.Drawing.Point(25, 121);
            this.tbPubHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPubHouse.Name = "tbPubHouse";
            this.tbPubHouse.ReadOnly = true;
            this.tbPubHouse.Size = new System.Drawing.Size(142, 20);
            this.tbPubHouse.TabIndex = 3;
            // 
            // tbPubYear
            // 
            this.tbPubYear.Location = new System.Drawing.Point(25, 89);
            this.tbPubYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPubYear.Name = "tbPubYear";
            this.tbPubYear.ReadOnly = true;
            this.tbPubYear.Size = new System.Drawing.Size(142, 20);
            this.tbPubYear.TabIndex = 2;
            // 
            // rtbSummary
            // 
            this.rtbSummary.Location = new System.Drawing.Point(25, 167);
            this.rtbSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.ReadOnly = true;
            this.rtbSummary.Size = new System.Drawing.Size(251, 219);
            this.rtbSummary.TabIndex = 1;
            this.rtbSummary.Text = "";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(25, 24);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(142, 20);
            this.tbName.TabIndex = 0;
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(18, 394);
            this.btnDodadi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(89, 26);
            this.btnDodadi.TabIndex = 2;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Enabled = false;
            this.btnIzbrisi.Location = new System.Drawing.Point(190, 394);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(89, 26);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Избриши";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Книги";
            // 
            // cbHorror
            // 
            this.cbHorror.AutoSize = true;
            this.cbHorror.Location = new System.Drawing.Point(18, 337);
            this.cbHorror.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbHorror.Name = "cbHorror";
            this.cbHorror.Size = new System.Drawing.Size(57, 17);
            this.cbHorror.TabIndex = 5;
            this.cbHorror.Text = "Хорор";
            this.cbHorror.UseVisualStyleBackColor = true;
            // 
            // cbMystery
            // 
            this.cbMystery.AutoSize = true;
            this.cbMystery.Location = new System.Drawing.Point(111, 337);
            this.cbMystery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMystery.Name = "cbMystery";
            this.cbMystery.Size = new System.Drawing.Size(78, 17);
            this.cbMystery.TabIndex = 6;
            this.cbMystery.Text = "Мистерија";
            this.cbMystery.UseVisualStyleBackColor = true;
            // 
            // cbThriller
            // 
            this.cbThriller.AutoSize = true;
            this.cbThriller.Location = new System.Drawing.Point(204, 337);
            this.cbThriller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbThriller.Name = "cbThriller";
            this.cbThriller.Size = new System.Drawing.Size(63, 17);
            this.cbThriller.TabIndex = 7;
            this.cbThriller.Text = "Трилер";
            this.cbThriller.UseVisualStyleBackColor = true;
            // 
            // cbFantasy
            // 
            this.cbFantasy.AutoSize = true;
            this.cbFantasy.Location = new System.Drawing.Point(18, 366);
            this.cbFantasy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFantasy.Name = "cbFantasy";
            this.cbFantasy.Size = new System.Drawing.Size(80, 17);
            this.cbFantasy.TabIndex = 8;
            this.cbFantasy.Text = "Фантазија";
            this.cbFantasy.UseVisualStyleBackColor = true;
            // 
            // cbDrama
            // 
            this.cbDrama.AutoSize = true;
            this.cbDrama.Location = new System.Drawing.Point(111, 366);
            this.cbDrama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDrama.Name = "cbDrama";
            this.cbDrama.Size = new System.Drawing.Size(61, 17);
            this.cbDrama.TabIndex = 9;
            this.cbDrama.Text = "Драма";
            this.cbDrama.UseVisualStyleBackColor = true;
            // 
            // cbRomance
            // 
            this.cbRomance.AutoSize = true;
            this.cbRomance.Location = new System.Drawing.Point(204, 366);
            this.cbRomance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRomance.Name = "cbRomance";
            this.cbRomance.Size = new System.Drawing.Size(71, 17);
            this.cbRomance.TabIndex = 10;
            this.cbRomance.Text = "Романса";
            this.cbRomance.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 426);
            this.Controls.Add(this.cbRomance);
            this.Controls.Add(this.cbDrama);
            this.Controls.Add(this.cbFantasy);
            this.Controls.Add(this.cbThriller);
            this.Controls.Add(this.cbMystery);
            this.Controls.Add(this.cbHorror);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbKnigi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKnigi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPubHouse;
        private System.Windows.Forms.TextBox tbPubYear;
        private System.Windows.Forms.RichTextBox rtbSummary;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.CheckBox cbHorror;
        private System.Windows.Forms.CheckBox cbMystery;
        private System.Windows.Forms.CheckBox cbThriller;
        private System.Windows.Forms.CheckBox cbFantasy;
        private System.Windows.Forms.CheckBox cbDrama;
        private System.Windows.Forms.CheckBox cbRomance;
    }
}

