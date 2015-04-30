namespace VPBiblioteka
{
    partial class Form2
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbImeKniga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbSodrzina = new System.Windows.Forms.RichTextBox();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbIzdavackaKukja = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGodIzdavanje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(48, 73);
            this.tbIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(280, 31);
            this.tbIme.TabIndex = 2;
            this.tbIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIme_KeyPress);
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // tbImeKniga
            // 
            this.tbImeKniga.Location = new System.Drawing.Point(48, 167);
            this.tbImeKniga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbImeKniga.Name = "tbImeKniga";
            this.tbImeKniga.Size = new System.Drawing.Size(280, 31);
            this.tbImeKniga.TabIndex = 4;
            this.tbImeKniga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbImeKniga_KeyPress);
            this.tbImeKniga.Validating += new System.ComponentModel.CancelEventHandler(this.tbImeKniga_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Име на книгата";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(352, 73);
            this.tbPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(280, 31);
            this.tbPrezime.TabIndex = 3;
            this.tbPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrezime_KeyPress);
            this.tbPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrezime_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(352, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Презиме";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(352, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Година на издавање";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(210, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кратка содржина";
            // 
            // rtbSodrzina
            // 
            this.rtbSodrzina.Location = new System.Drawing.Point(48, 369);
            this.rtbSodrzina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbSodrzina.Name = "rtbSodrzina";
            this.rtbSodrzina.Size = new System.Drawing.Size(584, 298);
            this.rtbSodrzina.TabIndex = 9;
            this.rtbSodrzina.Text = "";
            // 
            // btnDodadi
            // 
            this.btnDodadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDodadi.Location = new System.Drawing.Point(48, 679);
            this.btnDodadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(230, 71);
            this.btnDodadi.TabIndex = 10;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(400, 679);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(236, 71);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Откажи";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(352, 263);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(274, 33);
            this.cbGenre.TabIndex = 7;
            this.cbGenre.Validating += new System.ComponentModel.CancelEventHandler(this.cbGenre_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Жанр";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbIzdavackaKukja
            // 
            this.tbIzdavackaKukja.Location = new System.Drawing.Point(48, 265);
            this.tbIzdavackaKukja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIzdavackaKukja.Name = "tbIzdavackaKukja";
            this.tbIzdavackaKukja.Size = new System.Drawing.Size(280, 31);
            this.tbIzdavackaKukja.TabIndex = 6;
            this.tbIzdavackaKukja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIzdavackaKukja_KeyPress);
            this.tbIzdavackaKukja.Validating += new System.ComponentModel.CancelEventHandler(this.tbIzdavackaKukja_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(48, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Издавачка куќа";
            // 
            // tbGodIzdavanje
            // 
            this.tbGodIzdavanje.Location = new System.Drawing.Point(352, 167);
            this.tbGodIzdavanje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGodIzdavanje.Name = "tbGodIzdavanje";
            this.tbGodIzdavanje.Size = new System.Drawing.Size(280, 31);
            this.tbGodIzdavanje.TabIndex = 5;
            this.tbGodIzdavanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGodIzdavanje_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 794);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbIzdavackaKukja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.rtbSodrzina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGodIzdavanje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbImeKniga);
            this.Controls.Add(this.tbIme);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Додади Книга";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbImeKniga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbSodrzina;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIzdavackaKukja;
        private System.Windows.Forms.TextBox tbGodIzdavanje;
    }
}