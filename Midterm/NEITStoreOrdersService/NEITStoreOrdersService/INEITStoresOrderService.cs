using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NEITStoreOrdersService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INEITStoresOrderService
    {

        [OperationContract]
        float ReturnAmountEarned(float balance, float interest);

        [OperationContract]
        Account GetBankInformation(string AccountID);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Account
    {
        Accounts[] accounts;

        string accountID, ownerName;
        [DataMember]
        public Accounts[] Accounts
        {
            get
            {
                return accounts;
            }

            set
            {
                accounts = value;
            }
        }
        [DataMember]
        public string AccountID
        {
            get
            {
                return accountID;
            }

            set
            {
                accountID = value;
            }
        }
        [DataMember]
        public string OwnerName
        {
            get
            {
                return ownerName;
            }

            set
            {
                ownerName = value;
            }
        }
    }

    [DataContract]
    public class Accounts
    {
        Options options;
        string accountType;

        [DataMember]
        public Options Options
        {
            get
            {
                return options;
            }

            set
            {
                options = value;
            }
        }
        [DataMember]
        public string AccountType
        {
            get
            {
                return accountType;
            }

            set
            {
                accountType = value;
            }
        }

    }

    [DataContract]
    public class Options
    {
        string FreeChecking, OverDraftProtection;

        [DataMember]
        public string FreeChecking1
        {
            get
            {
                return FreeChecking;
            }

            set
            {
                FreeChecking = value;
            }
        }

        [DataMember]
        public string OverDraftProtection1
        {
            get
            {
                return OverDraftProtection;
            }

            set
            {
                OverDraftProtection = value;
            }
        }
    }
}
    