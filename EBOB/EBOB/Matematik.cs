using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBOB
{
    class Matematik
    {
        public static int EBOB(int s1, int s2)
        {
            int s = 1;  
            int bolen = 2;
            while (s1 != 1 && s2 != 1)
            {
                for (int i = 1; i <=(s1 > s2 ? s1 : s2); i++)
                {

                    if (s1 % bolen == 0  || s2%bolen==0)
                    {
                        if (s1 % bolen == 0 && s2 % bolen == 0)
                            s *= bolen;

                        if (s1 % bolen == 0)
                            s1 /= bolen;

                        if (s2 % bolen == 0)
                            s2 /= bolen;
                    }

                    else
                        bolen++;

                }
            }

            return s;

        }
    }
}
