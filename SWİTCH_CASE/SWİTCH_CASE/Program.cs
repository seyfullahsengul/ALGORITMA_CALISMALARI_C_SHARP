using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWİTCH_CASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int caseSwitch = rnd.Next(1, 10);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                    Console.WriteLine("Durum 2");
                    break;
                case 3:
                    Console.WriteLine($"case {caseSwitch}");
                    break;

                default:
                    Console.WriteLine($"Beklenmeyen Durum {caseSwitch}");
                    break;

            
            }
            Console.ReadLine();
        }
    }
}
