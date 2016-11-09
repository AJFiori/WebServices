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

namespace InClass3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {

        }

        private void btnGetWU_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            //XPathNodeIterator NodeIter2;
           // XPathNodeIterator NodeIter3;

            //Create Request
            String WeatherURL = "http://api.wunderground.com/api/0bf9935d99a6d397/conditions/q/MA/Boston.xml";
 
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

            /*
            NodeIter = nav.Select("//display_location/latitude[1]");
            NodeIter2 = nav.Select("//display_location/longitude[1]");
            NodeIter3= nav.Select("//feelslike_string");

            while (NodeIter.MoveNext() && NodeIter2.MoveNext() && NodeIter3.MoveNext())
            {
                rtResults.Text += "Latitude: " + NodeIter.Current.Value + " " +
                                  "Longitude: " + NodeIter2.Current.Value + Environment.NewLine +
                                  "Feels Like: " + NodeIter3.Current.Value;
            }
            */
            rtResults.Text += "Latitude: " + nav.SelectSingleNode("//display_location/latitude")
                 + " ";
            rtResults.Text += "Longitude: " + nav.SelectSingleNode("//display_location/longitude")
                + Environment.NewLine;
            rtResults.Text += "Feels Like: " + nav.SelectSingleNode("//feelslike_string");
        }
    }
}
