﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutlakdeger
{
    class sayi
    {
        public static int MutlakDeger(int n)
        {
            if (n > 0)
                return n;
            else if (n < 0)
            
                return -1 * n;
            
            else
                return 0;
        }
    }
}
