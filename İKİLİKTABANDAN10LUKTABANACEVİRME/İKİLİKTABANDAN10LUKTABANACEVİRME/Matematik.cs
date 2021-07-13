using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İKİLİKTABANDAN10LUKTABANACEVİRME
{
    class Matematik
    {
        public static int İkilikSayidan10lukSayiyaGec(string İkilikSayi)
        {
            int n = İkilikSayi.Length;     // ikilik sayinin uzunluğunu n değişkenine atadık.
            int[] basamaklar = new int[n];  // basamaklar adında yeni bir dizi oluşturup, dizi uzunluğunu n yaptık.
            int sayi10 = 0;   // onluk karşılığı için sayi10 değişkenini oluşturduk.
            bool kontrol = true;
            for (int i = 0; i < n; i++)
            {
                if (!(İkilikSayi[i] == '0' || İkilikSayi[i] == '1'))
                {
                    Console.WriteLine("\a Hatali Giriş");
                    kontrol = false;
                    break;
                }

                basamaklar[i] = (int)(İkilikSayi[i] - '0');
            }

            if (kontrol)
            {
                for (int i = 0; i < n; i++)
                    sayi10 += (int)Math.Pow(2, n - 1 - i) * basamaklar[i];
                Console.WriteLine("({0}) ikilik sayi = {1}", İkilikSayi, sayi10);
            }

            return sayi10;

        }
    }
}
