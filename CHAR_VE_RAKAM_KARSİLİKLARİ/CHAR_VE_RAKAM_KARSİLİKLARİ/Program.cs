using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAR_VE_RAKAM_KARSİLİKLARİ
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 65; i <=122; i++)
            {
                Console.Write("{0,5}", (char)i);
            }
            Console.ReadLine();
        }
    }
}
