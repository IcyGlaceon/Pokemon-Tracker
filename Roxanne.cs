using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PokeTracker
{
    public partial class Roxanne : Form
    {
        Routes form1 = new Routes();
        List<string> list = new List<string>();
        public  List<string> ppk = new List<string>();
        public Roxanne()
        {
            InitializeComponent();


            SqlConnection cnn = new SqlConnection();

            string connetionString = "data source=JEFFGOLDBLUM;initial catalog=Pokemon;User ID = sa; Password = game";

            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand cmd;
            SqlDataReader rdr;
            String sql = "Select * from Stats where ID in (074,074,299)";

            cmd = new SqlCommand(sql, cnn);
            rdr = cmd.ExecuteReader();

            string PKdata = "";

            while (rdr.Read())
            {
                for(int i = 0; i < 12; i++)
                {
                    PKdata = rdr.GetValue(i).ToString();
                    list.Add(PKdata);
                }
            }
        

            rdr.Close();
            cmd.Dispose();

        }

        public void Clear()
        {
            textBox1.Clear();
            HP.Clear();
            ATK.Clear();
            DEF.Clear();
            SPA.Clear();
            SPD.Clear();
            SPE.Clear();
        }

        private void GymPK1_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = "Selected Pokemon - ";
            for(int i = 1; i < 4; i++)
            {
                textBox1.Text = textBox1.Text + list[i] + " | ";
            }
            HP.Text = "HP - " + list[4];
            ATK.Text = "ATK - " + list[5];
            DEF.Text = "DEF - " + list[6];
            SPA.Text = "SPA - " + list[7];
            SPD.Text = "SPD - " + list[8];
            SPE.Text = "SPE - " + list[9];

        }

        private void GymPK2_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = "Selected Pokemon - ";
            for (int i = 1; i < 4; i++)
            {
                textBox1.Text = textBox1.Text + list[i] + " | ";
            }

            HP.Text = "HP - " + list[4];
            ATK.Text = "ATK - " + list[5];
            DEF.Text = "DEF - " + list[6];
            SPA.Text = "SPA - " + list[7];
            SPD.Text = "SPD - " + list[8];
            SPE.Text = "SPE - " + list[9];
        }

        private void GymPK3_Click(object sender, EventArgs e)
        {
            Clear();
            textBox1.Text = "Selected Pokemon - ";
            for (int i = 13; i < 15; i++)
            {
                textBox1.Text = textBox1.Text + list[i] + " | ";
            }

            HP.Text = "HP - " + list[16];
            ATK.Text = "ATK - " + list[17];
            DEF.Text = "DEF - " + list[18];
            SPA.Text = "SPA - " + list[19];
            SPD.Text = "SPD - " + list[20];
            SPE.Text = "SPE - " + list[21];
        }

        private void PPK1_Click(object sender, EventArgs e)
        {

        }

        private void Roxanne_Load(object sender, EventArgs e)
        {
            ppk.Add(form1.PK[0]);
            MessageBox.Show(ppk.ToString());
        }
    }
}
