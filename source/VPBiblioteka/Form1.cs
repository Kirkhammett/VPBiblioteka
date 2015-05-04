using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace VPBiblioteka
{
    public partial class Form1 : Form
    {
        string Connection = "SERVER=oriondev.me;" + "DATABASE=VPLibrary;"
        + "UID=Athena;" + "PASSWORD=masterofpuppets;";
        public Form1()
        {
            InitializeComponent();
            selectAll_books();
        }

        private void clearBooks()
        {
            tbName.Text = null;
            tbSurname.Text = null;
            tbPubHouse.Text = null;
            tbPubYear.Text = null;
            rtbSummary.Text = null;
        }

        public void selectAll_books()
        {
            clearBooks();
            btnNaracajKniga.Enabled = false;
            string Select = "SELECT * FROM Books;";
            MySqlDataReader Reader;
            MySqlConnection con = new MySqlConnection(Connection);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(Select, con);
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    lbKnigi.Items.Add(Reader.GetString("Book_name"));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Unable to connect to database!");
            }
            finally
            {
                con.Close();
            }
        }

        private void selectSpecific_books(String book)
        {
            clearBooks();
            string Select = "SELECT * FROM Books WHERE `Book_name` =" + '"' + book + '"' + ";";
            //Debugging the command
            //MessageBox.Show(Select, "Unable to connect to database!");
            MySqlDataReader Reader;
            MySqlConnection con = new MySqlConnection(Connection);
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(Select, con);
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    tbName.Text = (Reader.GetString("Auth_name"));
                    tbSurname.Text = (Reader.GetString("Auth_surname"));
                    tbPubHouse.Text = (Reader.GetString("Publish_house"));
                    tbPubYear.Text = (Reader.GetString("Publish_year"));
                    rtbSummary.Text = (Reader.GetString("Book_description"));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Unable to connect to database!");
            }
            finally
            {
                con.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gbGenres.Controls.Count; i++)
            {
                if (gbGenres.Controls[i] is RadioButton)
                {
                    RadioButton rb = (RadioButton)gbGenres.Controls[i];
                    rb.CheckedChanged += new System.EventHandler(gbGenres_CheckedChanged);
                }
            }
        }

        private void gbGenres_CheckedChanged(object sender, EventArgs e)
        {
            clearBooks();
            btnNaracajKniga.Enabled = false;
            RadioButton rb = sender as RadioButton;
            if (rb.Text == "Хорор" && rb.Checked)
            {
                string cmdHorror = "SELECT * FROM Books WHERE `genre`='Horror'";
                MySqlDataReader Reader;
                MySqlConnection con = new MySqlConnection(Connection);
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(cmdHorror, con);
                    lbKnigi.Items.Clear();
                    Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        lbKnigi.Items.Add(Reader.GetString("Book_name"));
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to database!");
                }
                finally
                {
                    con.Close();
                }
            }

            else if (rb.Text == "Мистерија" && rb.Checked)
            {
                string cmdMystery = "SELECT * FROM Books WHERE `genre`='Mystery'";
                MySqlDataReader Reader;
                MySqlConnection con = new MySqlConnection(Connection);
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(cmdMystery, con);
                    lbKnigi.Items.Clear();
                    Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        lbKnigi.Items.Add(Reader.GetString("Book_name"));
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to database!");
                }
                finally
                {
                    con.Close();
                }
            }
            else if (rb.Text == "Трилер" && rb.Checked)
            {
                string cmdThriller = "SELECT * FROM Books WHERE `genre`='Thriller'";
                MySqlDataReader Reader;
                MySqlConnection con = new MySqlConnection(Connection);
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(cmdThriller, con);
                    lbKnigi.Items.Clear();
                    Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        lbKnigi.Items.Add(Reader.GetString("Book_name"));
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to database!");
                }
                finally
                {
                    con.Close();
                }
            }
            else if (rb.Text == "Фантазија" && rb.Checked)
            {
                string cmdFantasy = "SELECT * FROM Books WHERE `genre`='Fantasy'";
                MySqlDataReader Reader;
                MySqlConnection con = new MySqlConnection(Connection);
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(cmdFantasy, con);
                    lbKnigi.Items.Clear();
                    Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        lbKnigi.Items.Add(Reader.GetString("Book_name"));
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to database!");
                }
                finally
                {
                    con.Close();
                }
            }
            else if (rb.Text == "Драма" && rb.Checked)
            {
                string cmdDrama = "SELECT * FROM Books WHERE `genre`='Drama'";
                MySqlDataReader Reader;
                MySqlConnection con = new MySqlConnection(Connection);
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(cmdDrama, con);
                    lbKnigi.Items.Clear();
                    Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        lbKnigi.Items.Add(Reader.GetString("Book_name"));
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to database!");
                }
                finally
                {
                    con.Close();
                }
            }
            else if (rb.Text == "Романса" && rb.Checked)
            {
                string cmdRomance = "SELECT * FROM Books WHERE `genre`='Romance'";
                MySqlDataReader Reader;
                MySqlConnection con = new MySqlConnection(Connection);
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(cmdRomance, con);
                    lbKnigi.Items.Clear();
                    Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        lbKnigi.Items.Add(Reader.GetString("Book_name"));
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Unable to connect to database!");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnAllGenres_Click(object sender, EventArgs e)
        {
            lbKnigi.Items.Clear();
            for (int i = 0; i < gbGenres.Controls.Count; i++)
            {
                if (gbGenres.Controls[i] is RadioButton)
                {
                    RadioButton rb = (RadioButton)gbGenres.Controls[i];
                    rb.Checked = false;
                }
            }
            selectAll_books();
        }

        private void lbKnigi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKnigi.SelectedItem != null && lbKnigi.Items.Count > 0)
            {
                String Kniga = lbKnigi.SelectedItem.ToString();
                selectSpecific_books(Kniga);
                btnNaracajKniga.Enabled = true;
            }
            else
            {
                btnNaracajKniga.Enabled = false;
            }
        }

        private void btnNaracajKniga_Click(object sender, EventArgs e)
        {
            Form3 naracka = new Form3(lbKnigi.SelectedItem.ToString());
            naracka.ShowDialog();
        }
    }
}
