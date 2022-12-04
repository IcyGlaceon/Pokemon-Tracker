using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeTracker
{
    public partial class Routes : Form
    {

        List<ComboBox> RouteList = new List<ComboBox>();
        public List<string> PK = new List<string>();

        public Routes()
        {
            InitializeComponent();
            Style();
        }

        class Connection
        {
            private string connetionString = "data source=(local);initial catalog=Pokemon; Trusted_Connection=True";

            public string ConnectionString
            {
                get { return connetionString; }
                set { connetionString = value; }
            }
        }


        public void ListCreate(ComboBox box, string id)
        {
            SqlConnection cnn = new SqlConnection();

            Connection connect = new Connection();
            cnn = new SqlConnection(connect.ConnectionString);
            cnn.Open();

            SqlCommand cmd;
            SqlDataReader rdr;
            String sql = "Select * from Stats where ID in (" + id + ")";

            cmd = new SqlCommand(sql, cnn);
            rdr = cmd.ExecuteReader();
            if (box.Items.Count == 0)
            {
                while (rdr.Read())
                {
                    box.Items.Add(rdr.GetValue(1).ToString());
                }
            }

            rdr.Close();
            cmd.Dispose();
        }

        public static void MakeVisible(ComboBox box, Button btn1, Button btn2, Button btn3)
        {
            if (box.Visible == false)
            {
                box.Visible = true;
                box.Enabled = true;
            }
            else
            {
                box.Visible = false;
                box.Enabled = false;
            }

            if (btn1.Visible == false)
            {
                btn1.Visible = true;
                btn1.Enabled = true;
            }
            else
            {
                btn1.Visible = false;
                btn1.Enabled = false;
            }

            if (btn2.Visible == false)
            {
                btn2.Visible = true;
                btn2.Enabled = true;
            }
            else
            {
                btn2.Visible = false;
                btn2.Enabled = false;
            }

            if (btn3.Visible == false)
            {
                btn3.Visible = true;
                btn3.Enabled = true;
            }
            else
            {
                btn3.Visible = false;
                btn3.Enabled = false;
            }
        }

        private void KilledPK_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int clicked = 0;
            for (int i = 0; i < RouteList.Count; i++)
            {
                if (RouteList[i].Name == (string)btn.Tag)
                {
                    if (RouteList[i].Name == (string)btn.Tag)
                    {
                        if (clicked == 0)
                        {
                            for (int p = 0; p < PK.Count; p++)
                            {
                                if (PK[p] == (string)RouteList[i].SelectedItem)
                                {
                                    PK.Remove(RouteList[i].SelectedItem.ToString()!);
                                }
                            }

                        }
                        clicked++;
                    }

                    RouteList[i].Enabled = false;
                }
            }
        }

        private void FailedPK_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for (int i = 0; i < RouteList.Count; i++)
            {
                if (RouteList[i].Name == (string)btn.Tag)
                {
                    RouteList[i].Enabled = false;
                }
            }
        }

        private void ActivePK_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int clicked = 0;

            if (btn.BackColor == Color.Green)
            {
                for (int i = 0; i < RouteList.Count; i++)
                {
                    if (RouteList[i].Name == (string)btn.Tag)
                    {
                        if (clicked == 0)
                        {
                            if (RouteList[i].SelectedItem != null)
                            {
                                MessageBox.Show(RouteList[i].SelectedItem.ToString() + " has been activated");
                                PK.Add(RouteList[i].SelectedItem.ToString()!);
                            }
                        }
                        clicked++;
                    }
                }

                btn.BackColor = Color.Red;
            } else if (btn.BackColor == Color.Red)
            {
                for (int i = 0; i < RouteList.Count; i++)
                {
                    if (RouteList[i].Name == (string)btn.Tag)
                    {
                        if (clicked == 0)
                        {
                            for (int p = 0; p < PK.Count; p++)
                            {
                                if (PK[p] == (string)RouteList[i].SelectedItem)
                                {
                                    MessageBox.Show(RouteList[i].SelectedItem.ToString() + " has been deactivated");
                                    PK.Remove(RouteList[i].SelectedItem.ToString()!);
                                }
                            }

                        }
                        clicked++;
                    }
                }
                btn.BackColor = Color.Green;
            }
        }
        private void Starter_Click(object sender, EventArgs e)
        {
            ListCreate(Starter, "252,255,258");
            if (!RouteList.Contains(Starter))
            {
                RouteList.Add(Starter);
            }
            MakeVisible(Starter, ActivePKStart, KilledPKStart, FailedPKStart);
        }

        private void R101_Click(object sender, EventArgs e)
        {

            ListCreate(Route101, "261,263,265");

            if (!RouteList.Contains(Route101))
            {
                RouteList.Add(Route101);
            }

            MakeVisible(Route101, ActivePK101, KilledPK101, FailedPK101);

        }

        private void R102_Click(object sender, EventArgs e)
        {
            ListCreate(Route102, "261,263,265,270,273,280");
            if (!RouteList.Contains(Route102))
            {
                RouteList.Add(Route102);
            }

            MakeVisible(Route102, ActivePK102, KilledPK102, FailedPK102);
        }

        private void R103_Click(object sender, EventArgs e)
        {
            ListCreate(Route103, "261,263,278");
            if (!RouteList.Contains(Route103))
            {
                RouteList.Add(Route103);
            }

            MakeVisible(Route103, ActivePK103, KilledPK103, FailedPK103);
        }

        private void PetalburgCity_Click(object sender, EventArgs e)
        {
            ListCreate(Petalburg, "183,118,129,341");
            if (!RouteList.Contains(Petalburg))
            {
                RouteList.Add(Petalburg);
            }

            MakeVisible(Petalburg, ActivePKPetal, KilledPKPetal, FailedPKPetal);
        }

        private void R104_Click(object sender, EventArgs e)
        {
            ListCreate(Route104, "183,261,265,276,278");
            if (!RouteList.Contains(Route104))
            {
                RouteList.Add(Route104);
            }

            MakeVisible(Route104, ActivePK104, KilledPK104, FailedPK104);
        }
        private void PetalW_Click(object sender, EventArgs e)
        {
            ListCreate(PetalburgWoods, "261,265,266,268,276,285,287");
            if (!RouteList.Contains(PetalburgWoods))
            {
                RouteList.Add(PetalburgWoods);
            }

            MakeVisible(PetalburgWoods, ActivePKPW, KilledPKPW, FailedPKPW);
        }

        private void Gym1_Click(object sender, EventArgs e)
        {
            Roxanne newForm = new Roxanne(PK);
            newForm.Show();
        }

        private void Gym2_Click(object sender, EventArgs e)
        {
            Brawly brawly = new Brawly(PK);
            brawly.Show();
        }
        private void R116_Click(object sender, EventArgs e)
        {
            ListCreate(Route116, "063,261,276,290,293,300");
            if (!RouteList.Contains(Route116))
            {
                RouteList.Add(Route116);
            }

            MakeVisible(Route116, ActivePK116, KilledPK116, FailedPK116);
        }

        private void RTunnel_Click(object sender, EventArgs e)
        {
            ListCreate(RusturfTunnel, "293");
            if (!RouteList.Contains(RusturfTunnel))
            {
                RouteList.Add(RusturfTunnel);
            }

            MakeVisible(RusturfTunnel, ActivePKRT, KilledPKRT, FailedPKRT);
        }

        private void Dewford_Click(object sender, EventArgs e)
        {
            ListCreate(DewfordTown, "072,129");
            if (!RouteList.Contains(DewfordTown))
            {
                RouteList.Add(DewfordTown);
            }

            MakeVisible(DewfordTown, ActivePKDewford, KilledPKDewford, FailedPKDewford);
        }

        private void R106_Click(object sender, EventArgs e)
        {
            ListCreate(Route106, "072,129");
            if (!RouteList.Contains(Route106))
            {
                RouteList.Add(Route106);
            }

            MakeVisible(Route106, ActivePK106, KilledPK106, FailedPK106);
        }

        private void R107_Click(object sender, EventArgs e)
        {
            ListCreate(Route107, "072,129");
            if (!RouteList.Contains(Route107))
            {
                RouteList.Add(Route107);
            }

            MakeVisible(Route107, ActivePK107, KilledPK107, FailedPK107);
        }

        private void Granite_Click(object sender, EventArgs e)
        {
            ListCreate(GraniteCave, "041,063,074,296,302,304");
            if (!RouteList.Contains(GraniteCave))
            {
                RouteList.Add(GraniteCave);
            }

            MakeVisible(GraniteCave, ActivePKGC, KilledPKGC, FailedPKGC);
        }

        private void RB3_Click(object sender, EventArgs e)
        {
            RivalBattle3 RB3 = new RivalBattle3(PK, Starter);
            RB3.Show();
        }

        private void Gym3_Click(object sender, EventArgs e)
        {
            Wattson wattson = new Wattson(PK);
            wattson.Show();
        }

        private void R109_Click(object sender, EventArgs e)
        {
            ListCreate(Route109, "072,129");
            if (!RouteList.Contains(Route109))
            {
                RouteList.Add(Route109);
            }

            MakeVisible(Route109, ActivePK109, KilledPK109, FailedPK109);
        }

        private void Slateport_Click(object sender, EventArgs e)
        {
            ListCreate(SlateportCity, "072,129");
            if (!RouteList.Contains(SlateportCity))
            {
                RouteList.Add(SlateportCity);
            }

            MakeVisible(SlateportCity, ActivePKSC, KilledPKSC, FailedPKSC);
        }

        private void R110_Click(object sender, EventArgs e)
        {
            ListCreate(Route110, "072,129,309,261,312,316,043,278,311");
            if (!RouteList.Contains(Route110))
            {
                RouteList.Add(Route110);
            }

            MakeVisible(Route110, ActivePK110, KilledPK110, FailedPK110);
        }

        public void Style()
        {
            ActivePKStart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePKStart.Width, ActivePKStart.Height, 40, 40));
            KilledPKStart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPKStart.Width, KilledPKStart.Height, 40, 40));
            FailedPKStart.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPKStart.Width, FailedPKStart.Height, 40, 40));
            ActivePK101.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePK101.Width, ActivePK101.Height, 40, 40));
            KilledPK101.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPK101.Width, KilledPK103.Height, 40, 40));
            FailedPK101.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPK101.Width, FailedPK103.Height, 40, 40));
            ActivePK103.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePK103.Width, ActivePK103.Height, 40, 40));
            KilledPK103.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPK103.Width, KilledPK103.Height, 40, 40));
            FailedPK103.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPK103.Width, FailedPK103.Height, 40, 40));
            ActivePK102.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePK102.Width, ActivePK102.Height, 40, 40));
            KilledPK102.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPK102.Width, KilledPK102.Height, 40, 40));
            FailedPK102.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPK102.Width, FailedPK102.Height, 40, 40));
            ActivePK104.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePK104.Width, ActivePK104.Height, 40, 40));
            KilledPK104.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPK104.Width, KilledPK104.Height, 40, 40));
            FailedPK104.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPK104.Width, FailedPK104.Height, 40, 40));
            ActivePK101.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePK101.Width, ActivePK101.Height, 40, 40));
            KilledPK101.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPK101.Width, KilledPK101.Height, 40, 40));
            FailedPK101.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPK101.Width, FailedPK101.Height, 40, 40));
            ActivePKPW.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePKPW.Width, ActivePKPW.Height, 40, 40));
            KilledPKPW.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPKPW.Width, KilledPKPW.Height, 40, 40));
            FailedPKPW.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPKPW.Width, FailedPKPW.Height, 40, 40));
            ActivePK116.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePK116.Width, ActivePK116.Height, 40, 40));
            KilledPK116.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPK116.Width, KilledPK116.Height, 40, 40));
            FailedPK116.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPK116.Width, FailedPK116.Height, 40, 40));
            ActivePKRT.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePKRT.Width, ActivePKRT.Height, 40, 40));
            KilledPKRT.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPKRT.Width, KilledPKRT.Height, 40, 40));
            FailedPKRT.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPKRT.Width, FailedPKRT.Height, 40, 40));
            ActivePKDewford.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePKDewford.Width, ActivePKDewford.Height, 40, 40));
            KilledPKDewford.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPKDewford.Width, KilledPKDewford.Height, 40, 40));
            FailedPKDewford.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPKDewford.Width, FailedPKDewford.Height, 40, 40));
            ActivePKPetal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePKPetal.Width, ActivePKPetal.Height, 40, 40));
            KilledPKPetal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPKPetal.Width, KilledPKPetal.Height, 40, 40));
            FailedPKPetal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPKPetal.Width, FailedPKPetal.Height, 40, 40));
            ActivePK106.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePK106.Width, ActivePK106.Height, 40, 40));
            KilledPK106.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPK106.Width, KilledPK106.Height, 40, 40));
            FailedPK106.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPK106.Width, FailedPK106.Height, 40, 40));
            ActivePK107.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePK107.Width, ActivePK107.Height, 40, 40));
            KilledPK107.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPK107.Width, KilledPK107.Height, 40, 40));
            FailedPK107.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPK107.Width, FailedPK107.Height, 40, 40));
            ActivePKGC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePKGC.Width, ActivePKGC.Height, 40, 40));
            KilledPKGC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPKGC.Width, KilledPKGC.Height, 40, 40));
            FailedPKGC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPKGC.Width, FailedPKGC.Height, 40, 40));
            ActivePK109.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePK109.Width, ActivePK109.Height, 40, 40));
            KilledPK109.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPK109.Width, KilledPK109.Height, 40, 40));
            FailedPK109.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPK109.Width, FailedPK109.Height, 40, 40));
            ActivePKSC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePKSC.Width, ActivePKSC.Height, 40, 40));
            KilledPKSC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPKSC.Width, KilledPKSC.Height, 40, 40));
            FailedPKSC.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPKSC.Width, FailedPKSC.Height, 40, 40));
            ActivePK110.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ActivePK110.Width, ActivePK110.Height, 40, 40));
            KilledPK110.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, KilledPK110.Width, KilledPK110.Height, 40, 40));
            FailedPK110.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, FailedPK110.Width, FailedPK110.Height, 40, 40));


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

/*
 * Bagde design credit to Zexion21
 * VS design Credit Saro
 * Map design credit to Dea Baylee
 */