using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.XPath;

namespace WcfOrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
      
        public int GetNumberOfOrders()
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            // Select the node and place the results in an iterator.
            return Convert.ToInt32(nav.Evaluate("count(//Order)"));

         
        }

        public double GetTotalCostForAnOrder(int OrderID)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            // Select the node and place the results in an iterator.
            return Convert.ToDouble(nav.Evaluate("sum(//Order[@id=\"" + OrderID + "\"]/Items/Item/TotalCost)"));
        }

        public List<Order> GetItemListForOrder(int OrderID)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;

            List<Order> itemOrder = new List<Order>();

            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            NodeIter = nav.Select("//Order[@id=\"" + OrderID + "\"]/Items/Item");

            while (NodeIter.MoveNext())
            {
                Order myOrder = new Order();
                myOrder.PartNo = NodeIter.Current.SelectSingleNode("PartNo").Value;
                myOrder.Description = NodeIter.Current.SelectSingleNode("Description").Value;
                myOrder.UnitPrice = Convert.ToDouble(NodeIter.Current.SelectSingleNode("UnitPrice").Value);
                myOrder.Quantity = Convert.ToInt32(NodeIter.Current.SelectSingleNode("Quantity").Value);

                if (NodeIter.Current.SelectSingleNode("CustomerOptions").Value.Equals(""))
                {
                    myOrder.Size = null;
                    myOrder.Color = null;
                }
                else
                {
                    myOrder.Size = NodeIter.Current.SelectSingleNode("//CustomerOptions/Size").Value;
                    myOrder.Color = NodeIter.Current.SelectSingleNode("//CustomerOptions/Color").Value;

                }
                itemOrder.Add(myOrder);

            }
            return itemOrder;
        }

        public int HowManyOrderedForAPartNo(string sPartNo)
        {
            XPathNavigator nav;
            XPathDocument docNav;
            
            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            // Select the node and place the results in an iterator.
            return Convert.ToInt32(nav.Evaluate("count(//Item[PartNo =\"" + sPartNo + "\"])"));
        }

        public Billing GetBillingAddressForAnOrder(int OrderID)
        {

            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator NodeIter;
            
            // Open the XML.
            string directory = HttpContext.Current.Server.MapPath(".");
            string strFilename = directory + "\\" + "OrderInfoLab3.xml";
            docNav = new XPathDocument(strFilename);

            // Create a navigator to query with XPath.
            nav = docNav.CreateNavigator();
            NodeIter = nav.Select("//Order[@id=\"" + OrderID + "\"]/BillingInformation");
            Billing myBilling = new Billing();
            while (NodeIter.MoveNext())
            {
                myBilling.Name = NodeIter.Current.SelectSingleNode("Name").Value;
                myBilling.Address = NodeIter.Current.SelectSingleNode("Address").Value;
                myBilling.City = NodeIter.Current.SelectSingleNode("City").Value;
                myBilling.State = NodeIter.Current.SelectSingleNode("State").Value;
                myBilling.ZipCode = NodeIter.Current.SelectSingleNode("ZipCode").Value;
            }
            return myBilling;
        }
    }
}
