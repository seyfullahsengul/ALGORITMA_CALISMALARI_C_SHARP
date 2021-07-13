using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRİSLER
{
    class Matris
    {
        /// <summary>
        /// Matris olusturur.
        /// </summary>
        /// <param name="satir">satir sayisi</param>
        /// <param name="sutun">sutun sayisi</param>
        /// <param name="min">min deger</param>
        /// <param name="mak">mak deger</param>
        /// <returns>X</returns>
        public static int[,] Olustur(int satir, int sutun, int min = 1, int mak= 9)
        {
            int[,] X = new int[satir, sutun];
            for (int i = 0; i < satir; i++)
                for (int j = 0; j < sutun; j++)
                 X[i, j] = new Random().Next(min, mak);
          
            return X;
        }

        /// <summary>
        /// parametre olarak aldığı matrisi ekrana yazar.
        /// </summary>
        /// <param name="X"></param>
        public static void Yazdir(int[,] X)
        {
            for (int i = 0; i < X.GetLength(0); i++)
            {
                for (int j = 0; j < X.GetLength(1) ; j++)
                
                    Console.Write("{0,5}", X[i, j]);
                    Console.WriteLine();
            }
        }

        /// <summary>
        /// sifir matrisi olusturur.
        /// </summary>
        /// <param name="satir">satir</param>
        /// <param name="sutun">sutun</param>
        /// <returns>sifir matrisi</returns>
        public static int[,] SifirMatrisiOlustur(int satir, int sutun)
        {

            return Olustur(satir, sutun, 0, 0);
        }

        /// <summary>
        /// birler matrisi oluşturur.
        /// </summary>
        /// <param name="satir"></param>
        /// <param name="sutun"></param>
        /// <returns>birler matrisi</returns>
        public static int[,] BirlerMatrisiOlustur(int satir, int sutun)
        {
            return Olustur(satir, sutun,1,1);
        }

        /// <summary>
        /// Kosegen Matris Olusturur.
        /// </summary>
        /// <param name="boyut">satır ve sutun sayisi</param>
        /// <param name="min">min degerler</param>
        /// <param name="maks">maks degerler</param>
        /// <returns>Kosegen matris</returns>
        public static int[,] KosegenMatrisOlustur(int boyut = 3, int min = 1, int maks = 9)
        {
            int[,] X = SifirMatrisiOlustur(boyut, boyut);
            for (int i = 0; i < boyut; i++)
                X[i, i] = new Random().Next(min, maks);
            return X;
        }
    }
}
