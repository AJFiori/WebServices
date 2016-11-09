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
            ContactMgrService.ContactManagerClient proxy = new ContactMgrService.ContactManagerClient();

            ContactMgrService.ContactInformation returnContact = new ContactMgrService.ContactInformation();
            returnContact = proxy.GetClientInformation("Gagnon");
            Console.WriteLine("Fax number is: " + returnContact.FaxNumber);

            int result1 = proxy.GetNumberOfContacts();
            Console.WriteLine("The number of contacts are: " + result1);
            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
