using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_UYGULAMA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Karakter Giriniz : ");
            char ch = (char)Console.Read();
            Console.ReadLine();

            if (char.IsUpper(ch))
            {
                Console.WriteLine("Girilen Karakter Büyük Bir Karakterdir.");
            }

            else if(char.IsLower(ch))
            {
                Console.WriteLine("Girilen Karakter Küçük Bir Karakterdir.");
            }

            else if (char.IsDigit(ch))
            {
                Console.WriteLine("Girilen Karakter Bir Rakamdır.");
            }

            else
            {
                Console.WriteLine("Girilen Karakter Alfanumerik Bir İfade Değildir.");
            }

            Console.ReadLine();
        }
    }
}   
