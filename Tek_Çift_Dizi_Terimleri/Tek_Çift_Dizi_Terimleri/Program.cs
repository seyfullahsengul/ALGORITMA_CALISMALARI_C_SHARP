using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_Çift_Dizi_Terimleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n degerini giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] X = new Siniflar().DiziOlustur(n);
            Console.Write("\n\n Dizinin Tek Terim sayisi : {0,3}", Siniflar.TekSayilarinSayisi(X));
            Console.Write("\n\n Dizinin Cift Terim sayisi : {0,3}", Siniflar.CiftSayilarinSayisi(X));

            int[] TekSayilarDizisi = Siniflar.TekDiziOlustur(X);
            int[] CiftSayilarDizisi = Siniflar.CiftDiziOlustur(X);

            Siniflar.yazdir(TekSayilarDizisi);

            Siniflar.yazdir(CiftSayilarDizisi);

            Console.ReadLine();

        }
    }
}
