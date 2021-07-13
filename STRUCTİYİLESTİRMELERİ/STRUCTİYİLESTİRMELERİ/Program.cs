using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCTİYİLESTİRMELERİ
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(10,"Ahmet","Yılmaz"),
                new Ogrenci(20,"Fatma","Dağ",false),
                new Ogrenci(30,"Mehmet","Avşar",true),
                new Ogrenci(40,"Asaf","Karlıdag")
            };

            ogrenciListesi.ForEach(o => Console.WriteLine(o));
            Console.ReadKey();
        }
    }
}
