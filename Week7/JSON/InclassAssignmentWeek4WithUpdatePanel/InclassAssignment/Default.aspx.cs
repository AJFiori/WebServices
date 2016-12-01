using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.Net;
using System.Web.Services.Protocols;


namespace InclassAssignment
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtDemoString.Text = "";
        }

        protected void btnCreditCardValidation_Click(object sender, EventArgs e)
        {
            net.webservicex.www.CCChecker myChecker = new net.webservicex.www.CCChecker();
            String result = myChecker.ValidateCardNumber("VISA", txtCreditCardNumber.Text);
           int counter;
           for (counter = 0; counter < 10000000; counter++)
           { }
               lblCCResult.Text = result;
        }

        protected void btnConvertAcceleration_Click(object sender, EventArgs e)
        {
            ConvertAcceleration.AccelerationUnit myAcceleration = new ConvertAcceleration.AccelerationUnit();
            lblAccelerationResult.Text = myAcceleration.ChangeAccelerationUnit(Convert.ToDouble(txtAmount.Text), ConvertAcceleration.Accelerations.centimeterPersquaresecond, ConvertAcceleration.Accelerations.footPersquaresecond).ToString() + " foot / second ** 2";

        }

        protected void btnCreditCardLongHand_Click(object sender, EventArgs e)
        {
            HttpWebRequest myHttpWebRequest = null;     //Declare an HTTP-specific implementation of the WebRequest class.
            HttpWebResponse myHttpWebResponse = null;   //Declare an HTTP-specific implementation of the WebResponse class
            XmlTextReader myXMLReader = null;           //Declare XMLReader           
            XPathNavigator nav;
            XPathDocument docNav;

            //Create Request
            String creditCardURL = "http://www.webservicex.net/CreditCard.asmx/ValidateCardNumber?cardType=MASTERCARD&cardNumber=" + txtGetCCNumber.Text;
 

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(creditCardURL);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "text/xml; encoding='utf-8'";
            //Get Response
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            //Load response stream into XMLReader
            myXMLReader = new XmlTextReader(myHttpWebResponse.GetResponseStream());

            docNav = new XPathDocument(myXMLReader);
            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            lblCCLonghandResult.Text = nav.Select("string").Current.Value;            
        }

    }
}
