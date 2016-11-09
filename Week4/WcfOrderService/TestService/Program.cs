using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    class Program
    {
        static void Main(string[] args)
        {
           
            OrderService.Service1Client proxy = new OrderService.Service1Client();

            OrderService.Billing returnBillingInfo = new OrderService.Billing();
            returnBillingInfo = proxy.GetBillingAddressForAnOrder(1);

            OrderService.Order[] returnOrderInfo = proxy.GetItemListForOrder(1);

   
            Console.WriteLine("Billing Information for Order 1");
            Console.WriteLine("Name = " + returnBillingInfo.Name);
            Console.WriteLine("Address = " + returnBillingInfo.Address);
            Console.WriteLine("City = " + returnBillingInfo.City);
            Console.WriteLine("State = " + returnBillingInfo.State);
            Console.WriteLine("ZipCode = " + returnBillingInfo.ZipCode);
            Console.WriteLine("Total Cost for order 1 = " + proxy.GetTotalCostForAnOrder(1));
            Console.WriteLine("The number of orders with Part 'JETSWEATER' = " + proxy.HowManyOrderedForAPartNo("JETSWEATER"));
            Console.WriteLine("Items in Order 1 (QTY, Part, Description)");
            Console.WriteLine(returnOrderInfo[0].Quantity + "  " + returnOrderInfo[0].PartNo + " " + returnOrderInfo[0].Description);
            Console.WriteLine(returnOrderInfo[1].Quantity + "  " + returnOrderInfo[1].PartNo + " " + returnOrderInfo[1].Description);
            Console.WriteLine(returnOrderInfo[2].Quantity + "  " + returnOrderInfo[2].PartNo + " " + returnOrderInfo[2].Description);
            Console.WriteLine("Enter CR To Exit");
            Console.ReadLine();

        }
    }
}
