using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İKİLİKTABANDAN10LUKTABANACEVİRME
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= Matematik.İkilikSayidan10lukSayiyaGec("101111");
            Console.WriteLine("Sayinin 10'luk Taban Karşılığı= {0}",a);
            Console.ReadLine();
        }
    }
}
