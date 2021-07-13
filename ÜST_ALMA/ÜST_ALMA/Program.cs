using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜST_ALMA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Taban Degerini Giriniz: ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üst Degerini Giriniz: ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("({0}^{1}) Değeri = {2}", s1, s2, Matematik.UstAlma(s1, s2));
            Console.ReadLine();

        }
    }
}
