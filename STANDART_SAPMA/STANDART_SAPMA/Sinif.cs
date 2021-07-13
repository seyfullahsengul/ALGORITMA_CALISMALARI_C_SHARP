using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STANDART_SAPMA
{
    class Sinif
    {
        public int[] DiziOlustur(int n)
        {
            int[] sayilardizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                sayilardizisi[i] = new Random(i).Next(1, 100);
                Console.Write("{0,5}", sayilardizisi[i]);
            }
            return sayilardizisi;
        }

        public static double AritmetikHesapla(int[] X)
        {
           double toplam = 0;
            for (int i = 0; i <X.Length; i++)
            {
                toplam += X[i];
            }

          return toplam / (X.Length);
        }

        public static double StandartHesapla(int [] X)
        {
            double Ortalama = AritmetikHesapla(X);
            double t = 0, f = 0;
            double std = 0;
            for (int i = 0; i < X.Length; i++)
            {
                f = X[i] - Ortalama;
                t += Math.Pow(f, 2);
            }
            std = t / (X.Length - 1);
            std = Math.Sqrt(std);
            return std;
        }
    }
}
