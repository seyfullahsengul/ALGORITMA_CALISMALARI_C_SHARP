using System;

namespace STRUCTİYİLESTİRMELERİ
{
    public struct Ogrenci
    {
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet = true)
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }




        public override string ToString()
        {
            return $"{Numara,-5} {Adi,-10}  {Soyadi,-10} {Cinsiyet,-8}";
        }

    }
}
