using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORDÖNGÜSÜ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet = 0;

            for (int i = 1000; i >=0 ; i -=5)
            {
                Console.Write("{0,5}",i);
                adet++;
            }
            Console.WriteLine("\n\n Toplamda {0} adet sayı vardır.", adet);
            Console.ReadLine();
        }
    }
}
