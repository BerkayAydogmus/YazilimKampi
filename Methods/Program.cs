using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string Urunadi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Products urun1 = new Products();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Products urun2 = new Products();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Products[] urunler = new Products[] {urun1,urun2};

            foreach (Products urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------");

            }

            Console.WriteLine("------------METOTLAR-----------");

            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut","Yeşil Armut",12, 10);
            sepetManager.Ekle2("Elma", "Kırmızı Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}
