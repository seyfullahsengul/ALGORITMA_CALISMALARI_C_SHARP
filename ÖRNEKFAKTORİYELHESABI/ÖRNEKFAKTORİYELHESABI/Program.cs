using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖRNEKFAKTORİYELhESABI
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            double x = 0;
            for (int i = 2; i <=8; i++)
            {
                t += matematik.fakto(i);
            }

            x = t / 7;

            Console.WriteLine("f(x)={0}/{1}={2}", t, 7, x);
            Console.ReadLine();

        }
    }
}
