using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Fiori_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetContacts_Click(object sender, EventArgs e)
        {

            string strFilename = Application.StartupPath + "\\ContactXML.xml";
            XmlDocument xmlDoc = new XmlDocument();


            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList contactInfo = elm.ChildNodes;

            //Latest version position 0
            rResults.Text += contactInfo[0].Name + " - " + contactInfo[0].FirstChild.InnerText
                + Environment.NewLine;
            //Current version position 1
            rResults.Text += contactInfo[1].Name + " - " + contactInfo[1].FirstChild.InnerText
                + Environment.NewLine;

            //loops through contacts and starts at position 2
            for (int iCount = 2; iCount < contactInfo.Count; iCount++)
            {
                XmlNodeList contactProperties = contactInfo[iCount].ChildNodes;
                rResults.Text += contactInfo[iCount].Name + Environment.NewLine;
                rResults.Text += "Sex: " + contactInfo[iCount].Attributes["sex"].Value
                    + Environment.NewLine;

                for (int jCount = 0; jCount < contactProperties.Count; jCount++)
                {
                    rResults.Text += contactProperties[jCount].Name + " - "
                        + contactProperties[jCount].InnerText + Environment.NewLine;
                }
            }
        }
    }
}
