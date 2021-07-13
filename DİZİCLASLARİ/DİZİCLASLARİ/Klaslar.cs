using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DİZİCLASLARİ
{
    class Klaslar
    {

        public int[] DiziOlustur(int limit)
        {
            int[] sayilar = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                sayilar[i] = new Random(i).Next(0, 100);
                Console.Write("{0,5}", sayilar[i]);
            }
            return sayilar;
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
