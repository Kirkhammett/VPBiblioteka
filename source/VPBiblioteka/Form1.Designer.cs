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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnNaracajKniga = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbGenres = new System.Windows.Forms.GroupBox();
            this.btnAllGenres = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.gbGenres.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKnigi
            // 
            this.lbKnigi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbKnigi.FormattingEnabled = true;
            this.lbKnigi.Location = new System.Drawing.Point(18, 39);
            this.lbKnigi.Margin = new System.Windows.Forms.Padding(2);
            this.lbKnigi.Name = "lbKnigi";
            this.lbKnigi.Size = new System.Drawing.Size(262, 264);
            this.lbKnigi.TabIndex = 0;
            this.lbKnigi.SelectedIndexChanged += new System.EventHandler(this.lbKnigi_SelectedIndexChanged);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 417);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Презиме на авторот";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(14, 67);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.ReadOnly = true;
            this.tbSurname.Size = new System.Drawing.Size(142, 20);
            this.tbSurname.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кратка содржина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Издавачка куќа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Година на издавање";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Име на авторот";
            // 
            // tbPubHouse
            // 
            this.tbPubHouse.Location = new System.Drawing.Point(14, 141);
            this.tbPubHouse.Margin = new System.Windows.Forms.Padding(2);
            this.tbPubHouse.Name = "tbPubHouse";
            this.tbPubHouse.ReadOnly = true;
            this.tbPubHouse.Size = new System.Drawing.Size(142, 20);
            this.tbPubHouse.TabIndex = 3;
            // 
            // tbPubYear
            // 
            this.tbPubYear.Location = new System.Drawing.Point(14, 104);
            this.tbPubYear.Margin = new System.Windows.Forms.Padding(2);
            this.tbPubYear.Name = "tbPubYear";
            this.tbPubYear.ReadOnly = true;
            this.tbPubYear.Size = new System.Drawing.Size(142, 20);
            this.tbPubYear.TabIndex = 2;
            // 
            // rtbSummary
            // 
            this.rtbSummary.Location = new System.Drawing.Point(14, 178);
            this.rtbSummary.Margin = new System.Windows.Forms.Padding(2);
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.ReadOnly = true;
            this.rtbSummary.Size = new System.Drawing.Size(251, 219);
            this.rtbSummary.TabIndex = 1;
            this.rtbSummary.Text = "";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(14, 30);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(142, 20);
            this.tbName.TabIndex = 0;
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(9, 414);
            this.btnDodadi.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(89, 26);
            this.btnDodadi.TabIndex = 2;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnNaracajKniga
            // 
            this.btnNaracajKniga.Enabled = false;
            this.btnNaracajKniga.Location = new System.Drawing.Point(202, 414);
            this.btnNaracajKniga.Margin = new System.Windows.Forms.Padding(2);
            this.btnNaracajKniga.Name = "btnNaracajKniga";
            this.btnNaracajKniga.Size = new System.Drawing.Size(89, 26);
            this.btnNaracajKniga.TabIndex = 3;
            this.btnNaracajKniga.Text = "Нарачај книга";
            this.btnNaracajKniga.UseVisualStyleBackColor = true;
            this.btnNaracajKniga.Click += new System.EventHandler(this.btnNaracajKniga_Click);
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
            // gbGenres
            // 
            this.gbGenres.Controls.Add(this.btnAllGenres);
            this.gbGenres.Controls.Add(this.radioButton4);
            this.gbGenres.Controls.Add(this.radioButton2);
            this.gbGenres.Controls.Add(this.radioButton5);
            this.gbGenres.Controls.Add(this.radioButton1);
            this.gbGenres.Controls.Add(this.radioButton6);
            this.gbGenres.Controls.Add(this.radioButton3);
            this.gbGenres.Location = new System.Drawing.Point(12, 308);
            this.gbGenres.Name = "gbGenres";
            this.gbGenres.Size = new System.Drawing.Size(279, 101);
            this.gbGenres.TabIndex = 9;
            this.gbGenres.TabStop = false;
            this.gbGenres.Text = "Жанрови";
            // 
            // btnAllGenres
            // 
            this.btnAllGenres.Location = new System.Drawing.Point(89, 65);
            this.btnAllGenres.Name = "btnAllGenres";
            this.btnAllGenres.Size = new System.Drawing.Size(101, 23);
            this.btnAllGenres.TabIndex = 10;
            this.btnAllGenres.Text = "Сите жанрови";
            this.btnAllGenres.UseVisualStyleBackColor = true;
            this.btnAllGenres.Click += new System.EventHandler(this.btnAllGenres_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(196, 42);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Романса";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Мистерија";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(104, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(60, 17);
            this.radioButton5.TabIndex = 13;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Драма";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Хорор";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 42);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(79, 17);
            this.radioButton6.TabIndex = 12;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Фантазија";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(196, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Трилер";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 451);
            this.Controls.Add(this.gbGenres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNaracajKniga);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbKnigi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbGenres.ResumeLayout(false);
            this.gbGenres.PerformLayout();
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
        private System.Windows.Forms.Button btnNaracajKniga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.GroupBox gbGenres;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnAllGenres;
    }
}

