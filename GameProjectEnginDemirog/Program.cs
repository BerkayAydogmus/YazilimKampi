using System;

namespace GameProjectEnginDemirog
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {
                Id=1,BirthYear=2000,FirstName="BERKAY",LastName="AYDOĞMUŞ",IdentityNumber= 12312312312
            });
        }
    }
}
