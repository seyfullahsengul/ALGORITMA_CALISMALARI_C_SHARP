using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAİRENİNALANİ
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yarıçapı {0} olan dairenin alanı = {1:F2}", r, AlanHesapla.Hesapla(r));
            Console.ReadLine();
        }
    }
}
