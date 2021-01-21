using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Berkay", "İlkay", "Koray", "Ömer" }; // ctrl k c ve k u
            //Console.WriteLine(isimler[0] + isimler[1] + isimler[2] + isimler[3]);

            List<string> isimler2 = new List<string> { "Berkay", "İlkay", "Koray", "Ömer" };
            Console.WriteLine(isimler2[0] + isimler2[1] + isimler2[2] + isimler2[3]);
            isimler2.Add("Nigga");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);





        }
    }
}
