using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2=10)
        {
            int toplam = sayi1 + sayi2;

            Console.WriteLine("SONUÇ : "+ toplam);
        }

        public void Bol(double pay, double payda)
        {
            double sonuc = pay / payda;

            Console.WriteLine("SONUÇ :" + sonuc);
        }
        public void Carpim(int Sayi1,int Sayi2)
        {
            int sonuc = Sayi1 * Sayi2;
            Console.WriteLine(sonuc);
        }

    }
}
