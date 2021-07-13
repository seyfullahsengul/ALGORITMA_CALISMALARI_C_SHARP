using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCTTEMELLERİ
{

    // Tanımlama
    public struct Ogrenci
    {
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet)
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; } // property - Özellik
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }


    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Struct - Kullanma

            Ogrenci Ogr = new Ogrenci();
            Ogr.Numara = 10;
            Ogr.Adi = "Ahmet";
            Ogr.Soyadi = "Yılmaz";
            Ogr.Cinsiyet = true;

            Console.WriteLine($"{Ogr.Numara} " + $"{Ogr.Adi} {Ogr.Soyadi} " + $"{Ogr.Cinsiyet} ");
            Console.ReadKey();

            // Alternatif Kullanım
            var Ogr2 = new Ogrenci() { Numara = 20, Adi = "Fatma", Soyadi = "Sahin", Cinsiyet = false };
            Console.WriteLine($"{Ogr2.Numara} " + $"{Ogr2.Adi} {Ogr2.Soyadi} " + $"{Ogr2.Cinsiyet} ");
            Console.ReadKey();

            // Alternatif Kullanım
            var Ogr3 = new Ogrenci(30, "Mehmet", "Avşar", true);
            Console.WriteLine($"{Ogr3.Numara} " + $"{Ogr3.Adi} {Ogr3.Soyadi} " + $"{Ogr3.Cinsiyet} ");
            Console.ReadKey();
        }
    }
}
