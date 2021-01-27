using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectEnginDemirog
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==2000 && gamer.FirstName =="BERKAY" && gamer.LastName =="AYDOĞMUŞ" && gamer.IdentityNumber == 12312312312)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
