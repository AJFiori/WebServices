using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceAccount.NEITStoresOrderServiceClient proxy = new ServiceAccount.NEITStoresOrderServiceClient();
            ServiceAccount.Accounts returnAccount = new ServiceAccount.Accounts();

            returnAccount = proxy.GetBankInformation("12345");

            float returnAccountNum = proxy.ReturnAmountEarned(100, 05);
            Console.ReadLine();
        }
    }
}
