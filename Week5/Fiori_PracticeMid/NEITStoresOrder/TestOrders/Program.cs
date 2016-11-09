using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceOrders.NEITStoresOrderServiceClient proxy = new ServiceOrders.NEITStoresOrderServiceClient();

            ServiceOrders.Order returnOrder = new ServiceOrders.Order();
            returnOrder = proxy.GetOrder(1);

            double returnDoubleOrderID = proxy.ReturnDoubeOrderID(2);
            Console.ReadLine();

        }
    }
}
