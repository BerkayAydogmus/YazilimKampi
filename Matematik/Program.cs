using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5);
            dortIslem.Topla(13,7);
            dortIslem.Topla(123,-103);



            dortIslem.Bol(15.2, 3.4);
            dortIslem.Bol(150, 50);


            dortIslem.Carpim(20,7);

        }


    }
}
