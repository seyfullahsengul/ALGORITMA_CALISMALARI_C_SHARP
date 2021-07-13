using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRİNGİFADEYİSAYİSALLAŞTİRMA
{
    class Program
    {
        static void Main(string[] args)
        {
            //DiziClass d = new DiziClass();
            // int[] dizi = d.IfadeyiDiziyeCev("10,11,12,13,14,15 ");

            int[] dizi = new DiziClass().IfadeyiDiziyeCev("25,40");
            Console.ReadLine();
        }
    }
}
