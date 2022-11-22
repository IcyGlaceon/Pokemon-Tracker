using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeTracker
{
    public partial class Form1 : Form
    {

        SqlConnection cnn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();

            Connection connect = new Connection();
            cnn = new SqlConnection(connect.ConnectionString);
            cnn.Open();

            SqlCommand cmd;
            SqlDataReader rdr;
            String sql = "Select * from Stats";

            cmd = new SqlCommand(sql, cnn);
            rdr = cmd.ExecuteReader();

            
            while (rdr.Read())
            {
               box.Items.Add(rdr.GetValue(1).ToString());        
            }
            
            rdr.Close();
            cmd.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {        
        }

        class Connection
        { 
            private string connetionString = "data source=JEFFGOLDBLUM;initial catalog=Pokemon;User ID = sa; Password = game";

            public string ConnectionString
            {
                get { return connetionString; }
                set { connetionString = value; }
            }
        }
    }


}