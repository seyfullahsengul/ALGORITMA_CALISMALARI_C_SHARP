using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirSayininAsalCarpanlari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} sayisinin asal carpanlari toplami = {1}", 60, Matematik.AsalCarpanlarınToplami(60));
            Console.ReadLine();
        }
    }
}
