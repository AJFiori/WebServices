using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            //Calls out to WS
            MorgageWS.MortgageIndex myMorgage = new MorgageWS.MortgageIndex();
            //Converts Int To String
            MorgageWS.MonthlyIndex myIndex = myMorgage.GetMortgageIndexByMonth
                (Convert.ToInt32(txtNumOne.Text), 
                 Convert.ToInt32(txtNumTwo.Text));

            //Grabs the 3 Month
            lblResultOne.Text = myIndex.ThreeMonthTreasuryBill.ToString();

            //Grabs the 6 Month
            lblResultTwo.Text = myIndex.SixMonthTreasuryBill.ToString();
        }
    }
}
