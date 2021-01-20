using System;

namespace YazılımKampı1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirildiMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }





            if (sistemeGirildiMi == true)
            {
                Console.WriteLine("Sisteme Giriş Yapılmıştır.");
            }
            else
            {
                Console.WriteLine("Giriş Yapılmamıştır.");
            }




            Console.WriteLine(kategoriEtiketi);
        }
    }
}