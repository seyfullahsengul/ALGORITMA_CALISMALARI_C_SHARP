using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DİZİCLASLARİ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n degerini giriniz: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new Klaslar().DiziOlustur(limit);
            
            Console.WriteLine("\n Dizinin en buyuk elemanı: {0}", Klaslar.enbuyuk(sayilar));
            Console.WriteLine("\n Dizinin en kucuk elemanı: {0}", Klaslar.enkucuk(sayilar));
            Console.ReadLine();
        }

        

        
    }
}
