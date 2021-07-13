using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DİZİNİNARİTMETİKORTALAMASİ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n degerini giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] X = new Sinif().Olustur(n);

            Console.WriteLine(" \n Dizinin aritmetik ortalamasi : {0:F2}", Sinif.AritmetikHesapla(X));
            Console.ReadLine();
        }
    }
}
