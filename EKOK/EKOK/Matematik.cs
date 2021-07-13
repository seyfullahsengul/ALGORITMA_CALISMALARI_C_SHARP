using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKOK
{
    class Matematik
    {
        public static int EKOK(int s1, int s2)
        {
            int s = 1;
            while (s1 != 1 || s2 != 1)
            {
                int bol = 2;
                for (int i = 1; i <= (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        s *= bol;
                        if (s1 % bol == 0)
                            s1 = s1 / bol;

                        if (s2 % bol == 0)
                            s2 = s2 / bol;
                    }
                    else
                        bol++;
                }
            }

            return s;

        }
    }
}
