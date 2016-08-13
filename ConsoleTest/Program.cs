using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LocationServiceClient;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string endpoint = ConfigurationManager.AppSettings["locEndPoint"];
            string devKey = ConfigurationManager.AppSettings["bingMapDevKey"];

            Console.ReadKey();
        }
    }
}
