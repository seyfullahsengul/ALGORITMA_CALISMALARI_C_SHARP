using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_Çift_Dizi_Terimleri
{
    class Siniflar
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


        public static int TekSayilarinSayisi(int [] X)
        {
            int teksayilarinsayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 1)
                    teksayilarinsayisi ++;
            }
            return teksayilarinsayisi;
        }

        public static int CiftSayilarinSayisi(int[] X)
        {
            int ciftsayilarinsayisi = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                    ciftsayilarinsayisi++;
            }
            return ciftsayilarinsayisi;
        }

        public static  int[] TekDiziOlustur(int[] X)
        {
            int dizidoyutu = TekSayilarinSayisi(X);
            int[] tekdizi = new int[dizidoyutu];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if(X[i]%2==1)
                {
                    tekdizi[y] = X[i];
                    y++;
                }
            }
            return tekdizi;
        }


        public static int[] CiftDiziOlustur(int[] X)
        {
            int dizidoyutu = CiftSayilarinSayisi(X);
            int[] ciftdizi = new int[dizidoyutu];
            int y = 0;
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] % 2 == 0)
                {
                    ciftdizi[y] = X[i];
                    y++;
                }
            }
            return ciftdizi;
        }

        public static void yazdir (int[] X)
        {
            Console.WriteLine("");
            for (int i = 0; i < X.Length; i++)
                Console.Write("{0,3}", X[i]);
            Console.WriteLine("");
        }
    }
}
