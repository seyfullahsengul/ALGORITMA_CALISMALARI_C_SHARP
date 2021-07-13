using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESLİHARFSAYİSİNİBULMA
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifade = Console.ReadLine();

            Console.WriteLine("{0} ifadesinde {1} Sesli Harf Vardır.", ifade, SesliHarfKlas.SesliHarfSayisi(ifade));
            Console.ReadLine();
        }
    }
}
