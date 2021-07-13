using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASTABLEUYGULAMASİ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baslik Giriniz: ");   // başlık okuma
            string baslik =Console.ReadLine();

            baslik = baslik.ToLower();

            var karakterSeti = new Hashtable()

            {
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'\'','-'},
                {'ğ','o'},
                {'.','-'}
            };

            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }


            Console.WriteLine(baslik);
            Console.ReadKey();
        }
    }
}
