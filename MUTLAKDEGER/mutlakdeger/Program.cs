using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutlakdeger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("|{0}| ={1}", n, sayi.MutlakDeger(n));
            Console.ReadLine();
        }
    }
}
