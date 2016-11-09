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

namespace InClass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadXMLValues_Click(object sender, EventArgs e)
        {

            string strFilename = Application.StartupPath + "\\XMLInfo.xml";
            XmlDocument xmlDoc = new XmlDocument();


            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList stocks = xmlDoc.GetElementsByTagName("RevisionDate");

            // Now you can check each node of the list
            foreach (XmlNode node in stocks)
            {
                Console.WriteLine(node.InnerText);
            }

        }

        private void btnGetElementByTagName_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\MultipleStockOutput.xml";
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList stocks = xmlDoc.GetElementsByTagName("Name");

            // Now you can check each node of the list
            foreach (XmlNode node in stocks)
            {
                Console.WriteLine(node.InnerText);
            }

        }
    }
}
