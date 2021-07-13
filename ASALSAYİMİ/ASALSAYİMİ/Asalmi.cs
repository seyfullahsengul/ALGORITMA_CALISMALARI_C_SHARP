﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASALSAYİMİ
{
    class Asalmi
    {
        public static bool AsalMi(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("En kücük asal sayi 2'dir.");
                return false;
            }

            bool kontrol = true;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                {
                    kontrol = false;
                    break;
                }
            return kontrol;
        }
    }
}
