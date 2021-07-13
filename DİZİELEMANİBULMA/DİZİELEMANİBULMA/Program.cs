using System;

namespace DİZİELEMANİBULMA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n degerini giriniz: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random(i).Next(0, 100);
                Console.Write("{0,5}", sayilar[i]);
            }
            Console.WriteLine("\n Dizinin en buyuk elemanı: {0}", enbuyuk(sayilar));
            Console.WriteLine("\n Dizinin en kucuk elemanı: {0}", enkucuk(sayilar));
            Console.ReadLine();
        }

        public static int enbuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > eb)
                    eb = dizi[i];
            }
            return eb;
        }

        public static int enkucuk(int[] dizi)
        {
            int ek = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ek)
                    ek = dizi[i];
            }
            return ek;
        }
    }
}
