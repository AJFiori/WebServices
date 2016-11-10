using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Problem3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodePrice, NodeGender, NodeSize;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\catalog.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            NodePrice = nav.Select("//catalog_item[price < 40]/price");
            NodeGender = nav.Select("//catalog_item[price < 40]/@gender");
            while (NodePrice.MoveNext() && NodeGender.MoveNext())
            {
                rtGenderPrice.Text += NodePrice.Current.Value + " - " + NodeGender.Current.Value + Environment.NewLine;
            }

            NodeSize = nav.Select("//catalog_item[size/@description=\"Small\"]/item_number");
            while (NodeSize.MoveNext())
            {
                rtItemNumber.Text += NodeSize.Current.Value + Environment.NewLine;
            }
        }
    }
}
