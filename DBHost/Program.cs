using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using DBService;
namespace DBHost
{
    class Program
    {
        static void Main(string[] args)
        {

            RadarService service = new RadarService();
            ServiceHost host = new ServiceHost(service);

            host.Open();
            Console.WriteLine("Serwer DBService został uruchomiony");
            Console.ReadKey();

        }
    }
}
