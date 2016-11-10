using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NEITStoreOrdersService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class NEITStoresOrderService : INEITStoresOrderService
    {
        Account INEITStoresOrderService.GetBankInformation(string AccountID)
        {
            Account myAccount = new Account();

            Accounts account1 = new Accounts();
            Options accountOptions = new Options();
            account1.AccountType = "Checking";
            accountOptions.FreeChecking1 = "N";
            accountOptions.OverDraftProtection1 = "Y";
            account1.Options = accountOptions;

            Accounts account2 = new Accounts();
            Options accountOptions1 = new Options();
            account2.Options = new Options();
            account2.AccountType = "Savings";
            accountOptions1.FreeChecking1 = null;
            accountOptions1.OverDraftProtection1 = "N";
            account2.Options = accountOptions1;


            Accounts[] accountArray = new Accounts[2];
            accountArray[0] = account1;
            accountArray[1] = account2;

            myAccount.Accounts = accountArray;
            myAccount.AccountID = "12345";
            myAccount.OwnerName = "Sam Spade";

            return myAccount;
        }

        float INEITStoresOrderService.ReturnAmountEarned(float balance, float interest)
        {
            return balance * interest;
        }
    }
}
