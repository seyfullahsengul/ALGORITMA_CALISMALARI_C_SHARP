using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASALSAYİMİ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Bir Tam Sayi Giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", Asalmi.AsalMi(n) ? "Asal sayidir." : "Asal degildir.");
            Console.ReadLine();
        }
    }
}
