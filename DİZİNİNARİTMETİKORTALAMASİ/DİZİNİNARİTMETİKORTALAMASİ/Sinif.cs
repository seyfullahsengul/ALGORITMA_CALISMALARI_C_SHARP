using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DİZİNİNARİTMETİKORTALAMASİ
{
    class Sinif
    {
        public int[] Olustur(int n)
        {
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                sayilar[i] = new Random(i).Next(1, 100);
                Console.Write("{0,5}", sayilar[i]);
            }
            return sayilar;
        }
        public static double AritmetikHesapla(int[] X)
        {
            double toplam = 0;
            for (int i = 0; i < X.Length; i++)
            {
                toplam += X[i];
            }
            return toplam / (X.Length);
        }
    }
}

