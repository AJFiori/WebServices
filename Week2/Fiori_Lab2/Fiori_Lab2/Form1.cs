using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace Fiori_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Billing info
        private void btnBilling_Click(object sender, EventArgs e)
        {
            rtBilling.Text = "";
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("//Order/BillingInformation/*");

            while (NodeIter.MoveNext())
            {
                rtBilling.Text += NodeIter.Current.Value + Environment.NewLine;
            }
        }

        //Shipping info
        private void btnShipping_Click(object sender, EventArgs e)
        {
            rtShipping.Text = "";
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("//Order/ShippingInformation/*");

            while (NodeIter.MoveNext())
            {
                rtShipping.Text += NodeIter.Current.Value + Environment.NewLine;
            }
        }

        //Item info
        private void btnItems_Click(object sender, EventArgs e)
        {
            rtItem.Text = "";
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
           

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\OrderInfo.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            //Calculates the Count of Items 
            lblItemsBought.Text = "Total Items Bought: " + nav.Evaluate("count(//Order/Items/Item)");
            
            //Calculates the Total Cost of Items
            lblCost.Text = "Total Cost: " + nav.Evaluate("sum(//Order/Items/Item/TotalCost)");
           
            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("//Order/Items/Item/*");
            
            while (NodeIter.MoveNext())
            {
            
                if (NodeIter.Current.Value.Equals(""))
                {
                    rtItem.Text += "No Customer Options" + Environment.NewLine;
                }
                else
                {
                    rtItem.Text += NodeIter.Current.Value + Environment.NewLine;
                    
                }
               
            }
        }
    }
}
