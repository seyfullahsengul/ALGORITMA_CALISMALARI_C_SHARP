using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKOK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci Sayiyi Giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Sayiyi Giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("OKEK({0},{1})={2}", s1, s2, Matematik.EKOK(s1, s2));
            Console.ReadLine();
        }
    }
}
