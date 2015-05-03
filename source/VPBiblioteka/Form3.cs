using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
namespace VPBiblioteka
{
    public partial class Form3 : Form
    {
        string kniga = String.Empty;
        public Form3(string ImeKniga)
        {
            InitializeComponent();
            this.kniga = ImeKniga;
            tbKniga.Text = kniga;
        }

        string Connection = "SERVER=oriondev.me;" + "DATABASE=VPLibrary;"
        + "UID=Athena;" + "PASSWORD=masterofpuppets;";
        private void insertCustomer(string Ime, string Prezime, string ImeKniga, string mail)
        {
            string InsertCustomer = string.Empty;
            if (tbBroj.Text != null)
            {
                InsertCustomer = "INSERT INTO `VPLibrary`.`Orders` (`Cust_Ime`, `Cust_Prezime`, `Cust_Kniga`, `Cust_Email`, `Cust_Broj`) VALUES"
                                + "('" + Ime + "'," + "'" + Prezime + "'," + "'" + ImeKniga + "'," + "\"" + mail + "\"," + "'" + tbBroj.Text + "'" + ");";

            }
            else
            {
                InsertCustomer = "INSERT INTO `VPLibrary`.`Orders` (`Cust_Ime`, `Cust_Prezime`, `Cust_Kniga`, `Cust_Email`) VALUES"
                + "('" + Ime + "'," + "'" + Prezime + "'," + "'" + ImeKniga + "'," + "\"" + mail + "\"" + ");";

            }
            //Debugging the command
            //MessageBox.Show(InsertCustomer);
            MySqlConnection con = new MySqlConnection(Connection);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(InsertCustomer, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Книгата е успешно нарачана!", "Успех!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Unable to connect to database!");
            }
            finally
            {
                con.Close();
                this.Close();
            }
        }

        private bool isValidMail(string mail)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(mail);
            if (match.Success)
                return true;
            else
                return false;
        }
        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Треба да внесете само букви!", "Грешка!");
            }
        }

        private void tbPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Треба да внесете само букви!", "Грешка!");
            }
        }

        private void tbBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '-' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Внесете валиден број, може да биде одделен со '-'.", "Несоодветен влез!");
            }

        }

        private void btnNaracajKniga_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(tbIme.Text)
               ||
               string.IsNullOrWhiteSpace(tbPrezime.Text)
                ||
               string.IsNullOrWhiteSpace(tbMail.Text)
              )
            {
                MessageBox.Show("Пополнете ги сите потребни полиња!", "Дефицит на информации!");
                return;
            }
            else if (!isValidMail(tbMail.Text))
            {
                MessageBox.Show("Внесете валидна e-mail адреса", "Грешка!");
                return;
            }
            insertCustomer(tbIme.Text, tbPrezime.Text, tbKniga.Text, tbMail.Text);
        }
    }
}
