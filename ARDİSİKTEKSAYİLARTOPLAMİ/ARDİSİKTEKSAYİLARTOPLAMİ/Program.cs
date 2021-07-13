using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARDİSİKTEKSAYİLARTOPLAMİ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0 dan {0}'ye kadar olan tek sayıların toplamı = {1}", n, TekSayilar.TekSayiToplami(n));
            Console.WriteLine("0 dan {0}'ye kadar olan tek sayıların toplamı = {1}", n, TekSayilar.TekSayiToplamiAlternatifCözüm(n));
            Console.WriteLine("0 dan {0}'ye kadar olan tek sayıların toplamı = {1}", n, TekSayilar.TekSayiToplamiFormülle(n));
            Console.ReadLine();
        }
    }
}
  