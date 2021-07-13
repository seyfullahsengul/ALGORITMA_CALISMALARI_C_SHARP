using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWİTC_CASE_1
{
    class Program
    {
        public enum Renkler { Kirmizi, Yesil, Mavi }
        static void Main(string[] args)
        {
            Renkler r = (Renkler)(new Random()).Next(0,2);
            Console.ReadLine();


            switch (r)
            {
                case Renkler.Kirmizi:
                    Console.WriteLine("Renk Kirmizidir.");
                    break;

                case Renkler.Yesil:
                    Console.WriteLine("Renk Yesildir.");
                    break;

                case Renkler.Mavi:
                    Console.WriteLine("Renk Mavidir.");
                    break;

                default:
                    Console.WriteLine("Renk Bilinmiyor.");
                    break;
            }
        }
    }
  }
