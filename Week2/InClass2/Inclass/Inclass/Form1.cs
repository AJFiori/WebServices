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


namespace Inclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReturnAll_Click(object sender, EventArgs e)
        {
            rtAllInfo.Text = "";
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\ContactXML.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            lblVersionDate.Text = "Version Date - " + nav.SelectSingleNode("/Contacts/LatestVersion").Value;
            lblVersionNumber.Text = "Version Number - " + nav.SelectSingleNode("/Contacts/CurrentVersion").Value;

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("/Contacts/Contact/*");

            while (NodeIter.MoveNext())
            {
                rtAllInfo.Text += NodeIter.Current.Value + Environment.NewLine;
            }

        }

        private void btnReturnMales_Click(object sender, EventArgs e)
        {
            rtMales.Text = "";
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\ContactXML.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();


            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("/Contacts/Contact[@sex='M']");

            while (NodeIter.MoveNext())
            {
                rtMales.Text += NodeIter.Current.Value + Environment.NewLine;
            }
        }

        private void btnLastName_Click(object sender, EventArgs e)
        {
            rtLastName.Text = "";
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string xmlFile = Application.StartupPath + "\\ContactXML.xml";
            docNav = new XPathDocument(xmlFile);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            // Select the node and place the results in an iterator.

            String searchString = "";

            searchString = "/Contacts/Contact[LastName='" + txtLastName.Text + "']";

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select(searchString);

            //Iterate through the results showing the element value.
            while (NodeIter.MoveNext())
            {
                rtLastName.Text += NodeIter.Current.Value + Environment.NewLine;
            }
        }
    }
}
