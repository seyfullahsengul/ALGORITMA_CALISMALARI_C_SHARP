using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARUYGULAMASI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = { "elma", "armut", "muz", "üzüm", "seftali" };
            var meyve = from m in meyveler
                        where m[0] == 'a'
                        select m;
            foreach (string m in meyve)
            Console.Write(m);
            Console.ReadLine();

        }
    }
}
