namespace BİR_SAYİNİN_ASAL_ÇARPANLARİ
{
    class Mat
    {
        public static string AsalCarpanıBul(int n)
        {
            string CarpanListesi = "";
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    CarpanListesi += i.ToString() + ",";
                }
                else
                    i++;
            }

            CarpanListesi = CarpanListesi.Substring(0, CarpanListesi.Length - 1);
            string[] carpanlar = CarpanListesi.Split(",");
            return CarpanListesi;


        }
    }
}
