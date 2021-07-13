using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEGİSKEN_UYGULAMASİ
{
    class Program
    {
        static void Main(string[] args)
        {

            byte minByte = System.Byte.MinValue;
            byte maxByte = System.Byte.MaxValue;
            Console.WriteLine("Byte -> \n Min : {0} \n Max: {1}", minByte, maxByte);
            Console.WriteLine("**********");

            int min16 = System.Int16.MinValue;
            int max16 = System.Int16.MaxValue;
            Console.WriteLine("Int16 -> \n Min : {0} \n Max: {1}", min16, max16);
            Console.WriteLine("**********");

            int min32 = System.Int32.MinValue;
            int max32 = System.Int32.MaxValue;
            Console.WriteLine("Int32 -> \n Min : {0} \n Max: {1}", min32, max32);
            Console.WriteLine("**********");

            Console.ReadLine();
        }
     
    }
}
