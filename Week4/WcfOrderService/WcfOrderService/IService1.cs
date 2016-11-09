using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfOrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int GetNumberOfOrders();

        [OperationContract]
        double GetTotalCostForAnOrder(int OrderID);

        [OperationContract]
        List<Order> GetItemListForOrder(int OrderID);

        [OperationContract]
        int HowManyOrderedForAPartNo(String sPartNo);

        [OperationContract]
        Billing GetBillingAddressForAnOrder(int OrderID);
       

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Order
    {
        string partNo;
        string description;
        double unitPrice;
        int quantity;
        double totalCost;
        string size;
        string color;

        [DataMember]
        public string PartNo
        {
            get
            {
                return partNo;
            }

            set
            {
                partNo = value;
            }
        }

        [DataMember]
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        [DataMember]
        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }

            set
            {
                unitPrice = value;
            }
        }

        [DataMember]
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        [DataMember]
        public double TotalCost
        {
            get
            {
                return totalCost;
            }

            set
            {
                totalCost = value;
            }
        }

        [DataMember]
        public string Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        [DataMember]
        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
    }


    [DataContract]
    public class Billing
    {
        string name;
        string address;
        string city;
        string state;
        string zipCode;

        [DataMember]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        [DataMember]
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        [DataMember]
        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        [DataMember]
        public string ZipCode
        {
            get
            {
                return zipCode;
            }

            set
            {
                zipCode = value;
            }
        }

        [DataMember]
        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        
       
    }
}
