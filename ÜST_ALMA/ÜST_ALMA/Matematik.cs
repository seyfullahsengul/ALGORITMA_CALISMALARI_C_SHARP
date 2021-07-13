using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜST_ALMA
{
    public class Matematik
    {
        /// <summary>
        /// parametre olarak aldığı taban ve kuvvete bağlı olarak UstAlma işleminini gerçekleştiri.
        /// </summary>
        /// <param name="taban">Taban</param>
        /// <param name="kuvvet">Kuvvet</param>
        /// <returns>Sonuc</returns>
        public static double UstAlma (double taban, double kuvvet)
        {
            double s = 1;
            for (int i = 1; i <=kuvvet; i++)
            {
                s *= taban;
            }
            return s;

        }
    }
}
