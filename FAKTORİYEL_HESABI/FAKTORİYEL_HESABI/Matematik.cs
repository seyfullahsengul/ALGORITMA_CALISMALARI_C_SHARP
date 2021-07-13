using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAKTORİYEL_HESABI
{
    class Matematik
    {
        public static int Faktoriyel(int n)
        {
            if (n <= 1)
                return 1;

            int f = 1;
            for (int i = 2; i <= n; i++)
                f *= i;

            return f;
        }
    }
}
