using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Added");

            }
            Console.WriteLine("Rejected");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Deleted");
        }
    }
}
