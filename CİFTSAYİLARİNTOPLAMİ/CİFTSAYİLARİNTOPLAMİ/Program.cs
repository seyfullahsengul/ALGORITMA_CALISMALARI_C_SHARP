using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CİFTSAYİLARİNTOPLAMİ
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Birinci Sayiyi Giriniz : ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayiyi Giriniz : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} sayısından {1} sayısına kadar olan çift sayiların toplami = {3}", n1, n2,
                toplam.Topla1(n2) - toplam.Topla1(n1));

            Console.ReadLine();
        }
    }
}
