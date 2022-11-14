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
        string connetionString;
        SqlConnection cnn;
        public Form1()
        {
            InitializeComponent();
            connetionString = "data source=JEFFGOLDBLUM;initial catalog=Pokemon;Integrated Security=true";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand cmd;
            SqlDataReader rdr;
            String sql, Output = "";

            
            sql = "Select Name, Type, HP, ATK, DEF, SPA, SPDE, SPD, LVL, Ability from Stats";
            cmd = new SqlCommand(sql,cnn);
            rdr = cmd.ExecuteReader();

            while(rdr.Read())
            {
                for(int i = 0; i < 10; i++)
                {
                    Output = Output + rdr.GetValue(i) + ",";
                }
            }

            MessageBox.Show(Output);
            rdr.Close();
            cmd.Dispose();
    }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.ShowDialog();
        }
    }
}