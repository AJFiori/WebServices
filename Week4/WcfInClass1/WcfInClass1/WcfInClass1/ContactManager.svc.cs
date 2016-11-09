using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfInClass1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ContactManager : IContactManager
    {

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int GetNumberOfContacts()
        {
            return 5;
        }

        public ContactInformation GetClientInformation(string lastName)
        {
            if (lastName == "Gagnon") {
                ContactInformation myContact = new ContactInformation();
                myContact.FirstName = "Jason";
                myContact.LastName = "Gagnon";
                myContact.PhoneNumber = "555-1212";
                myContact.FaxNumber = "111-1212";
                myContact.EmailAddress = "test@gmail.com";
                return myContact;
            }
            else {
                ContactInformation newContact = new ContactInformation();
                newContact.FirstName = "";
                newContact.LastName = "";
                newContact.PhoneNumber = "";
                newContact.FaxNumber = "";
                newContact.EmailAddress = "";
                return newContact;
            }
            
        }
    }
}
