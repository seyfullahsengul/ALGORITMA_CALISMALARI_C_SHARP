using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERİTURLERİALTUSTLİMİTLERİ
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8-BİT İNTEGER
            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt Limit       :{SByte.MinValue,10}");
            Console.WriteLine($"Üst Limit       :{SByte.MaxValue,10}");
            Console.WriteLine($"Boyut           :{sizeof(SByte),10}");
            Console.ReadKey();
            Console.WriteLine();

            // Unsigned 8-bit integer
            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt Limit       :{Byte.MinValue,10}");
            Console.WriteLine($"Üst Limit       :{Byte.MaxValue,10}");
            Console.WriteLine($"Boyut           :{sizeof(Byte),10}");
            Console.ReadKey();
            Console.WriteLine();

            //Signed 16-bit integer
            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt Limit       :{Int16.MinValue,10}");
            Console.WriteLine($"Üst Limit       :{Int16.MaxValue,10}");
            Console.WriteLine($"Boyut           :{sizeof(Int16),10}");
            Console.ReadKey();
            Console.WriteLine();

            //UnSigned 16-bit integer
            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt Limit       :{UInt16.MinValue,10}");
            Console.WriteLine($"Üst Limit       :{UInt16.MaxValue,10}");
            Console.WriteLine($"Boyut           :{sizeof(UInt16),10}");
            Console.ReadKey();
            Console.WriteLine();

            //Signed 32-bit integer
            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt Limit       :{Int32.MinValue,10}");
            Console.WriteLine($"Üst Limit       :{Int32.MaxValue,10}");
            Console.WriteLine($"Boyut           :{sizeof(Int32),10}");
            Console.ReadKey();
            Console.WriteLine();

            //UnSigned 32-bit integer
            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"Alt Limit       :{UInt32.MinValue,10}");
            Console.WriteLine($"Üst Limit       :{UInt32.MaxValue,10}");
            Console.WriteLine($"Boyut           :{sizeof(UInt32),10}");
            Console.ReadKey();
            Console.WriteLine();

            //Signed 64-bit integer
            Console.WriteLine(nameof(Int64));
            Console.WriteLine($"Alt Limit       :{Int64.MinValue,10}");
            Console.WriteLine($"Üst Limit       :{Int64.MaxValue,10}");
            Console.WriteLine($"Boyut           :{sizeof(Int64),10}");
            Console.ReadKey();
            Console.WriteLine();

            //UnSigned 64-bit integer
            Console.WriteLine(nameof(UInt64));
            Console.WriteLine($"Alt Limit       :{UInt64.MinValue,10}");
            Console.WriteLine($"Üst Limit       :{UInt64.MaxValue,10}");
            Console.WriteLine($"Boyut           :{sizeof(UInt64),10}");
            Console.ReadKey();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
