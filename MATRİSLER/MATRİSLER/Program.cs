using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRİSLER
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] X = Matris.Olustur(2,4);
            Matris.Yazdir(X);
            Console.ReadLine();

        }
    }
}
