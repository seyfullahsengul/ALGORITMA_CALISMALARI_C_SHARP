using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇEMBERİNÇEVRESİ
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yarıçapı {0} olan Çemberin çevresi ={1:F2}", r, 2 * pi * r);
            Console.ReadLine();

        }
    }
}
