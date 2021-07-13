using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SESLİHARFSAYİSİNİBULMA
{
    class SesliHarfKlas
    {
        public static int SesliHarfSayisi(string ifade)
        {
 
            int sesliharfsayisi = 0;
            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i] == 'a' || ifade[i] == 'A' ||
                    ifade[i] == 'e' || ifade[i] == 'E' ||
                    ifade[i] == 'ı' || ifade[i] == 'I' ||
                    ifade[i] == 'i' || ifade[i] == 'İ' ||
                    ifade[i] == 'o' || ifade[i] == 'O' ||
                    ifade[i] == 'ö' || ifade[i] == 'Ö' ||
                    ifade[i] == 'u' || ifade[i] == 'U' ||
                    ifade[i] == 'ü' || ifade[i] == 'Ü')
                    sesliharfsayisi++;
            }

            return sesliharfsayisi;
            
        }
    }
}
