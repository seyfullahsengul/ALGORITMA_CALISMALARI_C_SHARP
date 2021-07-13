using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace READONLY_SABİTİ
{
    class Program
    {

        readonly DateTime tarih;
        static void Main(string[] args)
        {

           Program _tarih = new Program ();
           Console.ReadLine();

        }
        public Program( )
        {
            tarih = DateTime.Now;
            Console.WriteLine(tarih);

        }
    }
}
