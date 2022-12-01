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
        public List<string> ppk;
        Button[] ListPPK;
       

        public Roxanne(List<string> K)
        {
            InitializeComponent();

            ListPPK = new[] { PPK1, PPK2, PPK3, PPK4, PPK5, PPK6 };

            ppk = K;
            if(ppk is not null )
            {
                for(int i = 0; i < form1.PK.Count; i++)
                {
                    ppk[i] = K[i]!;
                }
            }

            SqlConnection cnn = new SqlConnection();

            string connetionString = "data source=(local);initial catalog=Pokemon; Trusted_Connection=True";

            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand cmd;
            SqlDataReader rdr;
            String sql = "Select * from Stats";

            cmd = new SqlCommand(sql, cnn);
            rdr = cmd.ExecuteReader();

            string PKdata = "";

            while (rdr.Read())
            {
                for(int i = 0; i < 12; i++)
                {
                    PKdata = rdr.GetValue(i).ToString()!;
                    list.Add(PKdata);
                }
            }

            if (ppk is not null)
            {
                for (int i = 0; i < ppk.Count; i++)
                {
                    ListPPK[i].Text = ppk[i].ToString();
                }
            }


            rdr.Close();
            cmd.Dispose();

        }

        public void GClear()
        {
            PKInfo.Clear();
            HP.Clear();
            ATK.Clear();
            DEF.Clear();
            SPA.Clear();
            SPD.Clear();
            SPE.Clear();
        }

        private void GymPK1_Click(object sender, EventArgs e)
        {
            GClear();
            PKInfo.TextAlign = HorizontalAlignment.Left;
            PKInfo.Text = "Selected Pokemon - ";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "Geodude")
                {
                    for(int p = 0; p < 3; p++)
                    {
                        PKInfo.Text = PKInfo.Text + list[i + p] + " | ";
                    }

                    HP.Text = "HP - " + list[i + 3];
                    ATK.Text = "ATK - " + list[i + 4];
                    DEF.Text = "DEF - " + list[i + 5];
                    SPA.Text = "SPA - " + list[i + 6];
                    SPD.Text = "SPD - " + list[i + 7];
                    SPE.Text = "SPE - " + list[i + 8];
                }
            }
        }

        private void GymPK2_Click(object sender, EventArgs e)
        {
            GClear();
            PKInfo.TextAlign = HorizontalAlignment.Left;
            PKInfo.Text = "Selected Pokemon - ";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "Geodude")
                {
                    for (int p = 0; p < 3; p++)
                    {
                        PKInfo.Text = PKInfo.Text + list[i + p] + " | ";
                    }

                    HP.Text = "HP - " + list[i + 3];
                    ATK.Text = "ATK - " + list[i + 4];
                    DEF.Text = "DEF - " + list[i + 5];
                    SPA.Text = "SPA - " + list[i + 6];
                    SPD.Text = "SPD - " + list[i + 7];
                    SPE.Text = "SPE - " + list[i + 8];
                }
            }
        }

        private void GymPK3_Click(object sender, EventArgs e)
        {
            GClear();
            PKInfo.TextAlign = HorizontalAlignment.Left;
            PKInfo.Text = "Selected Pokemon - ";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "Nosepass")
                {
                    for (int p = 0; p < 3; p++)
                    {
                        PKInfo.Text = PKInfo.Text + list[i + p] + " | ";
                    }

                    HP.Text = "HP - " + list[i + 3];
                    ATK.Text = "ATK - " + list[i + 4];
                    DEF.Text = "DEF - " + list[i + 5];
                    SPA.Text = "SPA - " + list[i + 6];
                    SPD.Text = "SPD - " + list[i + 7];
                    SPE.Text = "SPE - " + list[i + 8];
                }
            }
        }

        private void Display_PlayerPK(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            PKInfo.TextAlign = HorizontalAlignment.Right;
            PKInfo.Text = "Selected Pokemon - ";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == btn.Text)
                {
                    for (int p = 0; p < 3; p++)
                    {
                        PKInfo.Text = PKInfo.Text + list[i + p] + " | ";
                    }

                    PHP.Text = "HP - " + list[i + 3];
                    PATK.Text = "ATK - " + list[i + 4];
                    PDEF.Text = "DEF - " + list[i + 5];
                    PSPA.Text = "SPA - " + list[i + 6];
                    PSPD.Text = "SPD - " + list[i + 7];
                    PSPE.Text = "SPE - " + list[i + 8];
                }
            }


        }
    }
}
