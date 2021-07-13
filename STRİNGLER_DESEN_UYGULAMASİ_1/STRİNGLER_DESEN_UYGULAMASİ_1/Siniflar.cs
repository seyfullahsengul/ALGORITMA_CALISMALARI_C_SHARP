using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRİNGLER_DESEN_UYGULAMASİ_1
{
    class Siniflar
    {
        public static void desen1(char c, int n)
        {
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine("{0,10}", new string(c, i));

            }
            Console.ReadLine();
        }
    }
}
