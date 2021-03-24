using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidatationManager());
            gamerManager.Add(new Gamer
            {
                GamerId = 1,
                FirstName = "Batuhan",
                LastName = "Ozturk",
                IdentityNumber = 123,
                BirthYear = 1995
            });
        }
    }
}
