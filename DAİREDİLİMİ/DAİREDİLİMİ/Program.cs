using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAİREDİLİMİ
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("yarıçapı {0} ve açısı 60 olan daire diliminin alanı = {1:F2}", r, Daire.DaireDilimi(r,60));
            Console.ReadLine();

        }
    }
}
