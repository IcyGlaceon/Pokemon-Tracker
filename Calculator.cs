using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeTracker
{
    public partial class Calculator : Form
    {
        string sign = "";
        string firstNum = "";
        float num1 = 0;
        float num2 = 0;
        bool period = false;
        public Calculator()
        {
            InitializeComponent();
        }
        private void UpdateOut()
        {
            if (!sign.Equals("")) firstNum = num1.ToString();
            textBoxOut.Text = firstNum+sign+num2;
        }

        private void AddNum(string num)
        {
            if (period&&!num2.ToString().Contains('.'))
            {
                num = "."+num;
                period = false;
            }

            num2 = float.Parse(num2.ToString()+num);
            UpdateOut();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            sign = "/";
            num1 = num2;
            num2 = 0;
            UpdateOut();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (sign)
            {
                case "+":
                    num2 += num1;
                    break;
                case "/":
                    num2 = num1/num2;
                    break;
                case "*":
                    num2 *= num1;
                    break;
                case "-":
                    num2 = num1 - num2;
                    break;
                case "%":
                    num2 = num1 % num2;
                    break;
            }

            num1 = 0;
            firstNum = "";
            sign = "";
            UpdateOut();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddNum("8");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddNum("7");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddNum("6");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddNum("5");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddNum("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddNum("1");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddNum("3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddNum("2");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddNum("1");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sign = "+";
            num1 = num2;
            num2 = 0;
            UpdateOut();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            sign = "-";
            num1 = num2;
            num2 = 0;
            UpdateOut();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            sign = "*";
            num1 = num2;
            num2 = 0;
            UpdateOut();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

                // num2 = int.Parse(num2.ToString()+num);
                if (num2.ToString().Length==1) num2 = 0;
                else num2 = float.Parse(num2.ToString().Remove(num2.ToString().Length-1));
                UpdateOut();
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddNum("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = "((((2 * Level / 5 + 2) * AttackStat * AttackPower / DefenseStat) / 50) + 2) * STAB * Weakness/Resistance * RandomNumber / 100";
        }
        /*

private void div_btn_Click(object sender, RoutedEventArgs e)
{
sign = "/";
num1 = num2;
num2 = 0;
UpdateOut();
}

private void mult_btn_Click(object sender, RoutedEventArgs e)
{
sign = "*";
num1 = num2;
num2 = 0;
UpdateOut();
}

private void add_btn_Click(object sender, RoutedEventArgs e)
{
sign = "+";
num1 = num2;
num2 = 0;
UpdateOut();
}

private void sub_btn_Click(object sender, RoutedEventArgs e)
{
sign = "-";
num1 = num2;
num2 = 0;
UpdateOut();
}

private void eq_btn_Click(object sender, RoutedEventArgs e)
{
switch (sign)
{
case "+":
  num2 += num1;
  break;
case "/":
  num2 = num1/num2;
  break;
case "*":
  num2 *= num1;
  break;
case "-":
  num2 = num1 - num2;
  break;
case "%":
  num2 = num1 % num2;
  break;
}

num1 = 0;
firstNum = "";
sign = "";
UpdateOut();

}


*/
    }
}
