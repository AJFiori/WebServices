using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Xml;
using System.Xml.XPath;

namespace ContactManager
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetInformation_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            String rootPath = Server.MapPath("~");
            string strFilename = rootPath + "\\ContactManager.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            lblVersionDate.Text = "Version Date - " + nav.SelectSingleNode("/ContactManager/VersionDate").Value;
            lblVersionNumber.Text = "Version Number - " + nav.SelectSingleNode("/ContactManager/VersionNumber").Value;


            //// Select the node and place the results in an iterator.
            NodeIter = nav.Select("/ContactManager/Contact");
            while (NodeIter.MoveNext())
            {
                XPathNodeIterator contactInfo = NodeIter.Current.SelectChildren(XPathNodeType.Element);
                txtResults1.Text = txtResults1.Text +" First Name: " + contactInfo.Current.SelectSingleNode("FirstName") + Environment.NewLine;
                txtResults1.Text = txtResults1.Text + contactInfo.Current.SelectSingleNode("LastName") + Environment.NewLine;
                txtResults1.Text = txtResults1.Text + contactInfo.Current.SelectSingleNode("PhoneNumber") + Environment.NewLine;
                txtResults1.Text = txtResults1.Text + contactInfo.Current.SelectSingleNode("FaxNumber") + Environment.NewLine;
                txtResults1.Text = txtResults1.Text + contactInfo.Current.SelectSingleNode("EmailAddress") + Environment.NewLine;
                if (contactInfo.Current.HasAttributes)
                {
                    txtResults1.Text = txtResults1.Text + contactInfo.Current.GetAttribute("Sex", "") + Environment.NewLine;
                }
                txtResults1.Text = txtResults1.Text + Environment.NewLine + "-----" + Environment.NewLine;
            }
        }

        protected void txtResults1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGetInformationAnotherWay_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            String rootPath = Server.MapPath("~");
            string strFilename = rootPath + "\\ContactManager.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();


            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("/ContactManager/Contact/*");

            while (NodeIter.MoveNext())
            {
                txtResults2.Text = txtResults2.Text + NodeIter.Current.Value + Environment.NewLine;
            }
        }

        protected void btnReturnOnlyMales_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            String rootPath = Server.MapPath("~");
            string strFilename = rootPath + "\\ContactManager.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();


            // Select the node and place the results in an iterator.
            NodeIter = nav.Select("/ContactManager/Contact[@Sex='M']");

            while (NodeIter.MoveNext())
            {
                XPathNavigator ContactInformation = NodeIter.Current;
                txtResults3.Text = txtResults3.Text + ContactInformation.SelectSingleNode("FirstName").ToString() + " ";
                txtResults3.Text = txtResults3.Text + ContactInformation.SelectSingleNode("LastName").ToString() + Environment.NewLine;
                txtResults3.Text = txtResults3.Text + ContactInformation.SelectSingleNode("PhoneNumber").ToString() + Environment.NewLine;
                txtResults3.Text = txtResults3.Text + ContactInformation.SelectSingleNode("FaxNumber").ToString() + Environment.NewLine;
                txtResults3.Text = txtResults3.Text + ContactInformation.SelectSingleNode("EmailAddress").ToString() + Environment.NewLine;
                txtResults3.Text = txtResults3.Text + Environment.NewLine + "------" + Environment.NewLine;
            }
        }

        protected void btnFindLastName_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            String rootPath = Server.MapPath("~");
            string strFilename = rootPath + "\\ContactManager.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            String searchString = "";

            searchString = "/ContactManager/Contact[LastName='" + txtLastName.Text + "']";

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select(searchString);

            while (NodeIter.MoveNext())
            {
                XPathNavigator ContactInformation = NodeIter.Current;
                txtResults4.Text = txtResults4.Text + ContactInformation.SelectSingleNode("FirstName").ToString() + " ";
                txtResults4.Text = txtResults4.Text + ContactInformation.SelectSingleNode("LastName").ToString() + Environment.NewLine;
                txtResults4.Text = txtResults4.Text + ContactInformation.SelectSingleNode("PhoneNumber").ToString() + Environment.NewLine;
                txtResults4.Text = txtResults4.Text + ContactInformation.SelectSingleNode("FaxNumber").ToString() + Environment.NewLine;
                txtResults4.Text = txtResults4.Text + ContactInformation.SelectSingleNode("EmailAddress").ToString() + Environment.NewLine;
                txtResults4.Text = txtResults4.Text + Environment.NewLine + "------" + Environment.NewLine;
            }
        }

        protected void btnBetterFindLastName_Click(object sender, EventArgs e)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            String rootPath = Server.MapPath("~");
            string strFilename = rootPath + "\\ContactManager.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();

            String searchString = "";

            searchString = "/ContactManager/Contact[starts-with(LastName,'" + txtBetterLastNameSearch.Text + "')]";

            // Select the node and place the results in an iterator.
            NodeIter = nav.Select(searchString);

            while (NodeIter.MoveNext())
            {
                XPathNavigator ContactInformation = NodeIter.Current;            
                txtResults5.Text = txtResults5.Text + ContactInformation.SelectSingleNode("FirstName").ToString() + " ";
                txtResults5.Text = txtResults5.Text + ContactInformation.SelectSingleNode("LastName").ToString() + Environment.NewLine;
                txtResults5.Text = txtResults5.Text + ContactInformation.SelectSingleNode("PhoneNumber").ToString() + Environment.NewLine;
                txtResults5.Text = txtResults5.Text + ContactInformation.SelectSingleNode("FaxNumber").ToString() + Environment.NewLine;
                txtResults5.Text = txtResults5.Text + ContactInformation.SelectSingleNode("EmailAddress").ToString() + Environment.NewLine;
                txtResults5.Text = txtResults5.Text + Environment.NewLine + "------" + Environment.NewLine;
            }
        }
    }
}
