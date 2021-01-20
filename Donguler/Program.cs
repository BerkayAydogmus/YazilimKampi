using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Başlangıç Kursu";
            string kurs3 = "Java Kursu";

            // array = dizi 

            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı",
                "Başlangıç Kursu", "Java Kursu", "Python Kursu" ,"C++" };


            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR BİTTİ.");

            foreach (string kurs in kurslar)  //foreach diziler için kullanılır.Dizi elemanlarını tek tek dolaşır.
            {
                Console.WriteLine(kurs);

            }



       
            Console.WriteLine("SAYFA SONU");
        }
    }
}
