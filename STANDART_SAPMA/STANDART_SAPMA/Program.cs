using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STANDART_SAPMA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n degerini giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] X = new Sinif().DiziOlustur(n);

            Console.WriteLine("\n Dizinin aritmetik ortalaması : {0:F2} \n Dizinin standart sapması : {1:F2}", 
                Sinif.AritmetikHesapla(X), Sinif.StandartHesapla(X));
            Console.ReadLine();
        }
    }
}
