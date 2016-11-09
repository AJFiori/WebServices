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

namespace XMLParsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnReadXMLFile_Click(object sender, EventArgs e)
        {
            // make life easy for now, put this file in the debug directory
            string sStartupPath = Application.StartupPath + "\\StockOutput.xml";
            if (File.Exists(sStartupPath))
            {
                XmlTextReader textReader = new XmlTextReader(sStartupPath);
                textReader.Read();
                // Check to see that you have a valid node
                while (textReader.Read())
                {
                    // Move to fist element
                    textReader.MoveToElement();
                    Console.WriteLine("XmlTextReader Properties Test");
                    Console.WriteLine("===================");

                    // Read this element's properties and display them on console

                    Console.WriteLine("Name:" + textReader.Name);

                    Console.WriteLine("Base URI:" + textReader.BaseURI);

                    Console.WriteLine("Local Name:" + textReader.LocalName);

                    Console.WriteLine("Attribute Count:" + textReader.AttributeCount.ToString());

                    Console.WriteLine("Depth:" + textReader.Depth.ToString());

                    Console.WriteLine("Line Number:" + textReader.LineNumber.ToString());

                    Console.WriteLine("Node Type:" + textReader.NodeType.ToString());

                    Console.WriteLine("Attribute Count:" + textReader.Value.ToString());

                }
            }
            else
                Console.Write("File does not exist");
        }

        private void btnReadXMLValues_Click(object sender, EventArgs e)
        {

         
            string sStartupPath = Application.StartupPath + "\\StockOutput.xml";
            XmlTextReader objXMLTextReader = new XmlTextReader(sStartupPath);
            string sName = "";
            while (objXMLTextReader.Read())
            {
                switch (objXMLTextReader.NodeType)
                {
                    case XmlNodeType.Element:
                        sName = objXMLTextReader.Name;
                        break;
                    case XmlNodeType.Text:                    
                        Console.WriteLine(sName + "-" + objXMLTextReader.Value);
                        break;
                       
                }
            } 

        }

        private void btnInnerText_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\StockOutput.xml";
            XmlDocument xmlDoc = new XmlDocument();

            if (File.Exists(strFilename))
            {
                xmlDoc.Load(strFilename);
                XmlElement elm = xmlDoc.DocumentElement;
                Console.WriteLine("{0}", elm.InnerText);
                Console.WriteLine("{0}", elm.OuterXml);
                Console.WriteLine("{0}", elm.InnerXml);
            }
            else
                Console.WriteLine("The file {0} could not be located",
                                  strFilename);                   

        }

        private void btnFindingChildren_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\StockOutput.xml";
            XmlDocument xmlDoc = new XmlDocument();

           
            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList stockInfo = elm.ChildNodes;

            for (int iCount = 0; iCount < stockInfo.Count; iCount++)
            {
                Console.WriteLine(stockInfo[0].Name);
                Console.WriteLine(stockInfo[0].FirstChild.Name + " - " + stockInfo[0].FirstChild.InnerText);
                Console.WriteLine("First Child Has children - " + stockInfo[0].FirstChild.HasChildNodes.ToString());
                XmlNodeList stockProperties = stockInfo[0].ChildNodes;

                for (int jCount = 0;jCount < stockProperties.Count; jCount ++)
                {
                    Console.WriteLine(stockProperties[jCount].Name + " - " + stockProperties[jCount].InnerText);
                }

            }

           
        }

        private void btnGetElementByTagName_Click(object sender, EventArgs e)
        {
            string strFilename = Application.StartupPath + "\\MultipleStockOutput.xml";
            XmlDocument xmlDoc = new XmlDocument();


            xmlDoc.Load(strFilename);
            XmlElement elm = xmlDoc.DocumentElement;
            XmlNodeList stocks = xmlDoc.GetElementsByTagName("Symbol");

            // Now you can check each node of the list
            foreach (XmlNode node in stocks)
            {
                Console.WriteLine(node.InnerText);   
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
