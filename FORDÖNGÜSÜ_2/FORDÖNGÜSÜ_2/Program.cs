using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORDÖNGÜSÜ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ttoplam = 0, ctoplam=0;
            Console.WriteLine("Bir Deger Giriniz : ");
                int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****TEK SAYİLAR*****");
            for (int i = 1; i <=limit; i +=2)
            {
                Console.Write("{0,5}", i);
                ttoplam += i;

            }

            Console.WriteLine("\n\n *****CİFT SAYİLAR*****");
            for (int i = 0; i <= limit; i += 2)
            {
                Console.Write("{0,5}", i);
                ctoplam += i;

            }

            Console.WriteLine("\n\n Tek Toplam = {0,5}  \n Cift Toplam = {1,5}", ttoplam, ctoplam);
            Console.ReadLine();
        }
    }
}
