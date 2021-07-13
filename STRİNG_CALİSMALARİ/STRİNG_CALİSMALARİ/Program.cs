using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRİNG_CALİSMALARİ
{
    class Program
    {
        static void Main(string[] args)
        {
            Char[] chars= { 'w', 'o', 'r', 'l', 'd' };
            sbyte[] bytes = { 0x41, 0x42, 0x43, 0x44, 0x45, 0x00 };

            string string1 = new string(chars);
            Console.Write("{0,5}", string1);
            Console.ReadLine();

            string stringFromBytes = null;

            unsafe
            {
                fixed (sbyte* pbytes = bytes)
                {
                    stringFromBytes = new string(pbytes);
                    Console.Write("{0,5}", stringFromBytes);
                    Console.ReadLine();
                }
            }
           
        }
    }
}
