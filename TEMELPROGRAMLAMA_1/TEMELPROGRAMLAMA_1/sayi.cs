using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEMELPROGRAMLAMA_1
{
    public class sayi
    {
        /// <summary>
        /// parametre olarak aldığı sayının tek mi yoksa cift mi olduğunu kontrol eder.
        /// </summary>
        /// <param name="n">sayi</param>
        /// <returns>Tek ise true aksi durumda false dönüş yapar.</returns>
        public bool TekMi(int n)
        {
            if (n % 2  == 1)
                return true;

        }
    }
}
