using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeTracker
{
    public partial class Brawly : Form
    {
        Routes form1 = new Routes();
        List<string> list = new List<string>();
        public List<string> ppk = new List<string>();
        Button[] ListPPK;


        public Brawly(List<string> K)
        {
            InitializeComponent();
            Style();

            ListPPK = new[] { PPK1, PPK2, PPK3, PPK4, PPK5, PPK6 };


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
                for (int i = 0; i < 12; i++)
                {
                    PKdata = rdr.GetValue(i).ToString()!;
                    list.Add(PKdata);
                }
            }

            ppk = K;

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
            Button btn = (Button)sender;
            PKInfo.TextAlign = HorizontalAlignment.Left;
            PKInfo.Text = "Selected Pokemon - ";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == btn.Text)
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

        private void GymPK2_Click(object sender, EventArgs e)
        {
            GClear();
            Button btn = (Button)sender;
            PKInfo.TextAlign = HorizontalAlignment.Left;
            PKInfo.Text = "Selected Pokemon - ";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == btn.Text)
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
            Button btn = (Button)sender;
            PKInfo.TextAlign = HorizontalAlignment.Left;
            PKInfo.Text = "Selected Pokemon - ";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == btn.Text)
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

        public void Style()
        {
            GymPK1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, GymPK1.Width, GymPK1.Height, 40, 40));
            GymPK2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, GymPK2.Width, GymPK2.Height, 40, 40));
            GymPK3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, GymPK3.Width, GymPK3.Height, 40, 40));
            PPK1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PPK1.Width, PPK1.Height, 40, 40));
            PPK2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PPK2.Width, PPK2.Height, 40, 40));
            PPK3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PPK3.Width, PPK3.Height, 40, 40));
            PPK4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PPK4.Width, PPK4.Height, 40, 40));
            PPK5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PPK5.Width, PPK5.Height, 40, 40));
            PPK6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PPK6.Width, PPK6.Height, 40, 40));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );
    }
}
