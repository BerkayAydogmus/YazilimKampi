using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectEnginDemirog
{
    //MİCROSERVİCE
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("KAYIT OLDU.");
            }
            else
            {
                Console.WriteLine("DOĞRULAMA BAŞARISIZ.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("KAYIT SİLİNDİ.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("KAYIT GÜNCELLENDİ.");
        }
    }
}
