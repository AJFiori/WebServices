using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace JSONWebService
{

    public class Employee
    {
        public string Name;
        public string Company;
        public string Address;
        public string Phone;
        public string Country;
    }

    /// <summary>
    /// Summary description for Service1
    /// </summary>    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]      
    public class Service1 : System.Web.Services.WebService
    {
        [WebMethod ]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public String OutputEmployeeJSON()
        {
            Employee[] e = new Employee[2];
            e[0] = new Employee();
            e[0].Name = "Bruce Ganek";
            e[0].Company = "The Allied Group";
            e[0].Address = "Cranston, RI";
            e[0].Phone = "120-4675";
            e[0].Country = "US";
            e[1] = new Employee();
            e[1].Name = "John Smith";
            e[1].Company = "Acme Company";
            e[1].Address = "D-195 Sector Noida";
            e[1].Phone = "334-4675";
            e[1].Country = "US";
            return new JavaScriptSerializer().Serialize(e);;
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public Employee[] OutputEmployeeXML()
        {
            Employee[] e = new Employee[2];
            e[0] = new Employee();
            e[0].Name = "Bruce Ganek";
            e[0].Company = "The Allied Group";
            e[0].Address = "Cranston, RI";
            e[0].Phone = "310-235-1535";
            e[0].Country = "US";
            e[1] = new Employee();
            e[1].Name = "John Smith";
            e[1].Company = "Acme Company";
            e[1].Address = "D-195 Sector Noida";
            e[1].Phone = "120-467500";
            e[1].Country = "US";
            return e;
        }
    }
}
