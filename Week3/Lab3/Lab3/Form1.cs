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
using System.Net;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetForeCast_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIterTitle;
            XPathNodeIterator NodeIterForeCast;
            

            //Create Request
            String WeatherURL = "http://api.wunderground.com/api/0bf9935d99a6d397/forecast/q/MA/Boston.xml";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(WeatherURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            
            NodeIterTitle = nav.Select("//forecastday/title");
            NodeIterForeCast = nav.Select("//forecastday/fcttext");
            

            while (NodeIterTitle.MoveNext() && NodeIterForeCast.MoveNext())
            {
                rtForeCast.Text += NodeIterTitle.Current.Value + Environment.NewLine +
                                   NodeIterForeCast.Current.Value + " " + Environment.NewLine
                                   + Environment.NewLine;
                                  
            }
            
        }

        private void btnZipCode_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIterTitle;
            XPathNodeIterator NodeIterForeCast;

            String zip = txtZip.Text;

            //Create Request
            String WeatherURL = "http://api.geonames.org/postalCodeSearch?postalcode=" + zip + "&maxRows=10&username=ajf1130";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(WeatherURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();


            NodeIterTitle = nav.Select("//postalcode");
            NodeIterForeCast = nav.Select("//name");


            while (NodeIterTitle.MoveNext() && NodeIterForeCast.MoveNext())
            {
                rtZipResults.Text += NodeIterTitle.Current.Value + Environment.NewLine +
                                   NodeIterForeCast.Current.Value + " " + Environment.NewLine
                                   + Environment.NewLine;

            }
        }

        private void btnGetNerbyZip_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIterTitle;
            XPathNodeIterator NodeIterForeCast;

            String zip = txtZip.Text;

            //Create Request
            String WeatherURL = "http://api.geonames.org/findNearbyPostalCodes?postalcode=" + zip + "&radius=10&username=ajf1130";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(WeatherURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();


            NodeIterTitle = nav.Select("//postalcode");
            NodeIterForeCast = nav.Select("//name");


            while (NodeIterTitle.MoveNext() && NodeIterForeCast.MoveNext())
            {
                rtZipResults.Text += NodeIterTitle.Current.Value + Environment.NewLine +
                                   NodeIterForeCast.Current.Value + " " + Environment.NewLine
                                   + Environment.NewLine;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtZipResults.Text = "";
            rtForeCast.Text = "";
        }
    }
}
