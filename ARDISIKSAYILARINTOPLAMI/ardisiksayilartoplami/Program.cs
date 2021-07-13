using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ardisiksayilartoplami
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} kadar olan sayiların toplamı = {1}'dir", n, nsayitoplami.NKadarSayiToplami(n));
            Console.ReadLine();
        }
    }
}
