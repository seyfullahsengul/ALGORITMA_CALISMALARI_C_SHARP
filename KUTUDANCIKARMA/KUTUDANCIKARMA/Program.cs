using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUTUDANCIKARMA
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 23;
            object o = i;
            i *= 2;
            i = (int)o;

            Console.WriteLine("Referans Türü: {0}", o);
            Console.ReadLine();

        }
    }
}
