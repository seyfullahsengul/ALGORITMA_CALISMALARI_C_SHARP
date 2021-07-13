using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHTABLETEMELLERİ
{
    class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new Hashtable(); // tanımlama

            sehirler.Add(6, "Ankara");     // Ekleme
            sehirler.Add(34, "İstanbul");  // Ekleme
            sehirler.Add(55, "Samsun");    // Ekleme
            sehirler.Add(23, "Elazığ");    // Ekleme


            Console.WriteLine("Elemanlar Üzerinde Dolasma");
            foreach (DictionaryEntry item in sehirler)   //Dolaşma
            {
                Console.WriteLine($"{item.Key,-3} " + $" -  {item.Value, -5}");
            }

            Console.WriteLine();

            Console.WriteLine("Anahtarlar (Keys)");    // Anahtarları alma
            var anahtarlar = sehirler.Keys;   
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Degerler (Values)");    // Degerleri alma
            var degerler = sehirler.Values;    
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Elemana Erişme");    //Elemana Erişme
            Console.WriteLine(sehirler[23]);

            Console.WriteLine();

            Console.WriteLine("Elemanı Silme");     // Eleman Silme
            sehirler.Remove(23);
            foreach (DictionaryEntry item in sehirler)   //Dolaşma
            {
                Console.WriteLine($"{item.Key,-3} " + $" -  {item.Value,-5}");
            }

            Console.ReadKey();


        }
    }
}
