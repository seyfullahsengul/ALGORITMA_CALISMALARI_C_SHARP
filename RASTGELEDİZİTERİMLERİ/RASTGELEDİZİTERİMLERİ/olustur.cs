using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASTGELEDİZİTERİMLERİ
{
    class olustur
    {
        public void diziOlus()
        {
            int[] array = new int[5];
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
