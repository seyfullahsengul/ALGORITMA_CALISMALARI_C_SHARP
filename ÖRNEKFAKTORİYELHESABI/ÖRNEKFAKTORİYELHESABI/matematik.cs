using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖRNEKFAKTORİYELhESABI
{
    class matematik
    {
        public static int fakto(int n)
        {
            int sonuc = 1;
            for (int i = 1; i <=n; i++)
            {
                sonuc *= i;
            }

            return sonuc;
        }
    }
}
