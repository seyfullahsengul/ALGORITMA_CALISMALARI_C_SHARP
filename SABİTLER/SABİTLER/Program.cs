using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABİTLER
{
    class Program
    {
        readonly static int yil = 2021;
        static void Main(string[] args)
        {
            YasHesaplama();
            //DaireninAlani();


        }

        private static void YasHesaplama()
        {
            //YasHesaplamaProgrami
            Console.WriteLine("Dogum Yiliniz: ");
            int dogumyili = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yasınız: {0}", (yil - dogumyili));
            Console.ReadLine();
        }

        private static void DaireninAlani()
        {
            //Dairenin alanını hesaplayan program

            const double pi = 3.1418;
            Double alan, r;

            Console.WriteLine("r=");

            r = Convert.ToDouble(Console.ReadLine());
            alan = pi * r * r;
            Console.WriteLine("r={0} için alan = {1}", r, alan);
            Console.ReadLine();
        }
        
    }
} 