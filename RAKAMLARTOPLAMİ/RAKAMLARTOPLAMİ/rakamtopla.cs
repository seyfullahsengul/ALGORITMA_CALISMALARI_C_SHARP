using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAKAMLARTOPLAMİ
{
    class rakamtopla
    {
        public static int RakamlariToplami(int n)
        {
            int toplam = 0, rakam = 0;
            while (n > 0)
            {
                rakam = n % 10;
                toplam += rakam;
                n = n / 10;
            }
            return toplam;
        }

    }
}
