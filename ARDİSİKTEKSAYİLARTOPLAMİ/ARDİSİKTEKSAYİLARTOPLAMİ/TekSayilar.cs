using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARDİSİKTEKSAYİLARTOPLAMİ
{
    class TekSayilar
    {
        public static int TekSayiToplami(int n)
        {
            int toplam = 0;
            for (int i = 1; i <= n; i += 2)
                toplam += i;
            return toplam;
        }

        public static int TekSayiToplamiAlternatifCözüm(int n)
        {
            int toplam = 0;
            for (int i = 1; i <= n; i++)
                if (i % 2 == 1)
                    toplam += i;
            return toplam;
        }

        public static int TekSayiToplamiFormülle(int n)
        {
            int x, y, toplam;
            x = n + 1;
            y = x / 2;
            toplam = y * y;
            return toplam;
        }
    }
}
