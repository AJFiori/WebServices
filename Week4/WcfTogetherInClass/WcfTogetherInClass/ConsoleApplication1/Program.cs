using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeService.Service1Client proxy = new PracticeService.Service1Client();
            
            PracticeService.CompositeType myType = new PracticeService.CompositeType();
            PracticeService.CompositeType returnType = new PracticeService.CompositeType();

            myType.BoolValue = true;
            myType.StringValue = "vbjbhkn";

            returnType = proxy.GetDataUsingDataContract(myType);
            string result = proxy.GetData(2);
            Console.WriteLine(result);
            Console.WriteLine(returnType.BoolValue + ", " + returnType.StringValue);
            Console.ReadLine();
        }
    }
}
