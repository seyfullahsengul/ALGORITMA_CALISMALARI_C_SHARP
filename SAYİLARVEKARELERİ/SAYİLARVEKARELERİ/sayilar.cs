using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAYİLARVEKARELERİ
{
    class sayilar
    {
        public void Kare()
        {
            int[] number = new int[5];
            int[] square = new int[5];
            int n = number.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                number[i] = new Random().Next(15, 30);
                square[i] = number[i] * number[i];
                Console.WriteLine("{0} karesi = {1}", number[i], square[i]);
            }
            Console.ReadLine();
        }
    }
}
