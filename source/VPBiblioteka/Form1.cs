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


        private void selectAll_books()
        {
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
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gbGenres.Controls.Count; i++)
            {
                if(gbGenres.Controls[i] is RadioButton)
                {
                    RadioButton rb = (RadioButton)gbGenres.Controls[i];
                    rb.CheckedChanged += new System.EventHandler(gbGenres_CheckedChanged);
                }
            }
        }

        private void gbGenres_CheckedChanged(object sender, EventArgs e)
        {
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
    }
}
