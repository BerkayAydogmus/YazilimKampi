using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Ömer Aydoğmuş";
            kurs1.İzlenmeOrani = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.Egitmen = "Berkay Aydoğmuş";
            kurs2.İzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "İlkay Aydoğmuş";
            kurs3.İzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.İzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar) 
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen + " " + kurs.İzlenmeOrani);
            }




            Console.WriteLine("Hello World!");
        }
    }

    class Kurs // class tanımlama
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}
