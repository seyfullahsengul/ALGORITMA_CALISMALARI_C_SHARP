using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ardisiksayilartoplami
{
    class nsayitoplami
    {
        public static int NKadarSayiToplami(int n)
        {
            int t = 0;
            for (int i = 0; i <= n; i++)
            {
                t += i;
            }
            return t;
        }
    }
}
