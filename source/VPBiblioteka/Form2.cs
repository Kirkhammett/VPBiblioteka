using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPBiblioteka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String genre = "Horror,Mystery,Thriller,Fantasy,Drama,Romance";
            String[] genres = genre.Split(',');

            foreach (String gen in genres)
            {
                cbGenre.Items.Add(gen);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (tbIme.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbIme, "Задолжително внеси име на автор.");
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
                e.Cancel = false;
            }
        }

        private void tbPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrezime.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbPrezime, "Задолжително внеси презиме на автор.");
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbPrezime, null);
                e.Cancel = false;
            }

        }

        private void tbImeKniga_Validating(object sender, CancelEventArgs e)
        {
            if (tbImeKniga.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbImeKniga, "Задолжително внеси име на книга.");
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbImeKniga, null);
                e.Cancel = false;
            }

        }

        private void tbIzdavackaKukja_Validating(object sender, CancelEventArgs e)
        {
            if (tbIzdavackaKukja.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbIzdavackaKukja, "Задолжително внеси издавачка куќа.");
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbIzdavackaKukja, null);
                e.Cancel = false;
            }
        }

        private void cbGenre_Validating(object sender, CancelEventArgs e)
        {
            if (cbGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Изберете соодветен жанр!", "Несоодветен влез!");
                e.Cancel = false;
            }

            else
            {
                errorProvider1.SetError(cbGenre, null);
                e.Cancel = false;
            }
        }

        private void tbGodIzdavanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') //Backspace, smee da se brise
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Внесете валидни години, само бројки.", "Несоодветен влез!");
            }
            if (tbGodIzdavanje.Text.Trim().Length > 3)
            {
                MessageBox.Show("Внесете валидна големина на години, 4 бројки.", "Несоодветен влез!");
                tbGodIzdavanje.Text = "";
                e.Handled = true;
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {

            if (
                string.IsNullOrWhiteSpace(tbIme.Text)
                ||
                string.IsNullOrWhiteSpace(tbImeKniga.Text)
                ||
                string.IsNullOrWhiteSpace(tbPrezime.Text)
                ||
                string.IsNullOrWhiteSpace(tbIzdavackaKukja.Text)
                ||
                string.IsNullOrWhiteSpace(tbGodIzdavanje.Text)
                ||
                string.IsNullOrWhiteSpace(rtbSodrzina.Text)
               )
            {
                MessageBox.Show("Сите полиња се задолжителни и мора да бидат пополнети за да се додаде книга!", "Недосататок на податоци!");
                return;
            }
            //TODO: Change this dumb thing and actually add support for a real insert.
            MessageBox.Show("Книгата е успешно додадена!", "Успех!");
        }
    }
}
