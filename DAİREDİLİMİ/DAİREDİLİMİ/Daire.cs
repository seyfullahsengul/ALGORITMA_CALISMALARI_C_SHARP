using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAİREDİLİMİ
{
   public  class Daire
    {
        public const double pi = 3.14;
        public static double DaireDilimi(double r, double aci)
        {
            return ((pi * r * r) * aci) / 360;
        }
    }
}
