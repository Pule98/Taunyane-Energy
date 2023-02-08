using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taunyane_s_Enger
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void purchasebtn_Click(object sender, EventArgs e)
        {
            if(meterNumbertxt.Text.Length ==11  && amounttxt.Text.Length > 0)
            {
                double amount = Convert.ToDouble(amounttxt.Text);


                if (amount >= 30)
                {
                    double vat = amount * 0.15;
                    amount = amount - vat;
                    double unit = amount / 3.50;

                    int group1, group2, group3, group4, group5;

                    group1 = rand.Next(1000, 10000);
                    group2 = rand.Next(1000, 10000);
                    group3 = rand.Next(1000, 10000);
                    group4 = rand.Next(1000, 10000);
                    group5 = rand.Next(1000, 10000);
                

                    string token = group1.ToString() + " " + group2.ToString() + " "+ group3.ToString() + " " + group4.ToString() + " " + group5.ToString();
                    tokenlb.Text = token;
                    unitlb.Text = unit.ToString() + " Kwh";
                    vatlb.Text = "R" + vat.ToString();

                }
                else
                {
                    MessageBox.Show("Minimum amount should be R30.00");
                }
            }
            else
            {
                MessageBox.Show("Meter Number and Amount is required!");
            }
        }
    }
}
