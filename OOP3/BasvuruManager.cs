using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggersServices)//Method injection
        {
            //başvuran bilgilerini değerlendirme
            //bla bla bla işler kod olarak yazılabilir

           
            krediManager.Hesapla();
            loggersServices.Log();
            //foreach (var loggers in loggersServices)
            //{
            //    loggers.Log();
            //}

            

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
