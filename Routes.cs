using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeTracker
{
    public partial class Routes : Form
    {

        ComboBox[] BoxList = new ComboBox[10];
        public List<string> PK = new List<string>();
        
        public Routes()
        {
            InitializeComponent();
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
            String sql = "Select * from Stats where ID in ("+ id +")";

            cmd = new SqlCommand(sql, cnn);
            rdr = cmd.ExecuteReader();
            if(box.Items.Count == 0)
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

        private void Starter_Click(object sender, EventArgs e)
        {
            ListCreate(Starter, "252,255,258");
            for (int i = 0; i < BoxList.Length; i++)
            {
                BoxList[i] = Starter;
            }

            MakeVisible(Starter, ActivePKStart, KilledPKStart, FailedPKStart);
        }

        private void R101_Click(object sender, EventArgs e)
        {

            ListCreate(Route101, "261,263,265");
            for (int i = 0; i < BoxList.Length; i++)
            {
                BoxList[i] = Route101;
            }

            MakeVisible(Route101, ActivePK101, KilledPK101, FailedPK101);
            
        }
        private void KilledPK_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            for(int i = 0; i < BoxList.Length; i++)
            {
                if (BoxList[i].Name == (string)btn.Tag)
                {
                    BoxList[i].Enabled = false;
                }
            }
        }
            
        private void ActivePK_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int clicked = 0;
            
            if(btn.BackColor == Color.Green)
            {
                for(int i = 0; i < BoxList.Length; i++)
                {
                    if (BoxList[i].Name == (string)btn.Tag)
                    {
                        if(clicked == 0)
                        {
                            if(BoxList[i].SelectedItem != null)
                            {
                            PK.Add(BoxList[i].SelectedItem.ToString()!);
                                clicked++;
                            }

                        }
                    }
                }

                btn.BackColor = Color.Red;
            }else if(btn.BackColor == Color.Red)
            {
                for (int i = 0; i < BoxList.Length; i++)
                {
                    if (BoxList[i].Name == (string)btn.Tag)
                    {
                        if (clicked == 0)
                        {
                            if (BoxList[i].SelectedItem != null)
                            {
                                PK.Remove(BoxList[i].SelectedItem.ToString()!);
                                clicked++;
                            }
                        }
                    }
                }

                btn.BackColor = Color.Green;
            }
        }

        private void R102_Click(object sender, EventArgs e)
        {
            ListCreate(Route102, "261,263,265,270,273,280");
            for (int i = 0; i < BoxList.Length; i++)
            {
                BoxList[i] = Route102;
            }

            MakeVisible(Route102, ActivePK102, KilledPK102, FailedPK102);
        }

        private void R103_Click(object sender, EventArgs e)
        {
            ListCreate(Route103, "261,263,278");
            for (int i = 0; i < BoxList.Length; i++)
            {
                BoxList[i] = Route103;
            }

            MakeVisible(Route103, ActivePK103, KilledPK103, FailedPK103);
        }

        private void PetalburgCity_Click(object sender, EventArgs e)
        {
            ListCreate(Petalburg, "183,118,129,341");
            for (int i = 0; i < BoxList.Length; i++)
            {
                BoxList[i] = Petalburg;
            }

            MakeVisible(Petalburg, ActivePKPetal, KilledPKPetal, FailedPKPetal);
        }

        private void R104_Click(object sender, EventArgs e)
        {
            ListCreate(Route104, "183,261,265,276,278");
            for (int i = 0; i < BoxList.Length; i++)
            {
                BoxList[i] = Route104;
            }

            MakeVisible(Route104, ActivePK104, KilledPK104, FailedPK104);
        }

        private void Gym1_Click(object sender, EventArgs e)
        {
            Roxanne newForm = new Roxanne(PK);
            newForm.Show();
        }


    }


}