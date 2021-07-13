using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CİFTSAYİLARİNTOPLAMİ
{
    class toplam
    {
        public static int Topla1(int n1)
        {
            int toplam1 = 0;
            for (int i = 0; i < n1; i += 2)
                    toplam1 += i;
            return toplam1;
        }

        public static int Topla2(int n2)
        {
            int toplam2 = 0;
            for (int i = 0; i < n2; i += 2)
                    toplam2 += i;
            return toplam2;
        }
    }
}
