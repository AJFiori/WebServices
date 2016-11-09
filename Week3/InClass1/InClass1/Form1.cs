using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Calls to the WebService
            CalculatorWS.Calculator myCalculator = new CalculatorWS.Calculator();

           lblResult.Text = myCalculator.Add(Convert.ToInt32(txtNumOne.Text),
               Convert.ToInt32(txtNumTwo.Text)).ToString();
        }

        //Subtract
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //Calls to the WebService
            CalculatorWS.Calculator myCalculator = new CalculatorWS.Calculator();

            lblResult.Text = myCalculator.Subtract(Convert.ToInt32(txtNumOne.Text), 
                Convert.ToInt32(txtNumTwo.Text)).ToString();
        }
    }
}
