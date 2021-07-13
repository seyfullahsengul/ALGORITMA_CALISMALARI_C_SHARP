using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRİNGİFADEYİSAYİSALLAŞTİRMA
{
    class DiziClass
    {
        public int[] IfadeyiDiziyeCev(string ifade)
        {

            string[] bolunenIfade = ifade.Split(',');

            int n = bolunenIfade.Length;

            int[] SayisalDizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                SayisalDizi[i] = Convert.ToInt32(bolunenIfade[i]);
                Console.WriteLine("Dizinin [{0}]={1}", i + 1, SayisalDizi[i]);
            }

            return SayisalDizi; 
        }
    }
}
