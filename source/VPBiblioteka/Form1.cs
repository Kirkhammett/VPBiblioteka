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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              string Select = "SELECT * FROM Books;";
              string Connection = "SERVER=oriondev.me;" + "DATABASE=VPLibrary;"
             + "UID=Athena;" + "PASSWORD=masterofpuppets;";
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
            catch(MySqlException ex)
          {
              DialogResult.OK.ToString(ex.Message);
          }
          finally
          {
              con.Close();
          }


        }
    }
}
