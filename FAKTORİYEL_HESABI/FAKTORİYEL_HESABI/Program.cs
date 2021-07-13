using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAKTORİYEL_HESABI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Faktoriyelini Hesaplamak İstediğiniz Degeri Giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", n, Matematik.Faktoriyel(n));
            Console.ReadLine();
        }
    }
}
