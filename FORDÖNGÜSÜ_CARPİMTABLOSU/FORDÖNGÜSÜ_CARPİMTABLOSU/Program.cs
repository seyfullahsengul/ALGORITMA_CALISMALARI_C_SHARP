using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORDÖNGÜSÜ_CARPİMTABLOSU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n*** ÇARPIM TABLOSU ***\n\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n**********************\n");
                for (int j = 1; j <=10; j++)
                {
                    Console.WriteLine("{0,3} * {1,3} = {2,3}", i, j, i * j);
                }

            }
            Console.ReadLine();
        }
    }
}
