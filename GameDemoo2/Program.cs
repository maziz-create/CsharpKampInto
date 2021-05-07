using GameDemo2.Abstract;
using GameDemo2.Concrete;
using GameDemo2.Entities;
using System;

namespace GameDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User()
            {
                Id = 1,
                IdentificationNumber = "12345",
                FirstName = "Polat",
                LastName = "Alemdar",
                DateOfBirth = new DateTime(1998,6,12)

            };
            IEStateVerificationService eStateVerificationManager = new EStateVerificationManager();
            eStateVerificationManager.Verification(user1);

            Game gameCOD = new Game()
            {
                Id = 1,
                Name = "Call of Duty",
                Price = 187,
                ReleaseDate = new DateTime(1998, 6, 12)
            };

            Game gameCSGO = new Game()
            {
                Id = 2,
                Name = "Counter-Strike: Global Offensive",
                Price = 450,
                ReleaseDate = new DateTime(1999, 1, 26)
            };

            Campaign campaign = new Campaign()
            {
                Id = 1,
                Content = "Süper Cuma",
                Discount = 0.5
            };

            Console.WriteLine("\n--------------------------------------\n\n\n");

            BaseGameManager gManagerForCOD = new CallOfDutyManager();
            OrderManager orderManager = new OrderManager();
            IUserManagerService userManager = new UserManager();

            orderManager.Sell(user1, gameCOD, campaign);
            gManagerForCOD.GameSetup(gameCOD);
            gManagerForCOD.Save(gameCOD, user1);
            gManagerForCOD.Play(gameCOD, user1);
            gManagerForCOD.Delete(gameCOD, user1);


            Console.WriteLine("\n--------------------------------------\n\n\n");

            BaseGameManager gManagerForCSGO = new CSGOManager();
            orderManager.Sell(user1, gameCSGO, campaign);
            gManagerForCSGO.GameSetup(gameCSGO);
            gManagerForCSGO.Save(gameCSGO, user1);
            gManagerForCSGO.Play(gameCSGO, user1);
            gManagerForCSGO.Delete(gameCSGO, user1);

            Console.WriteLine("\n--------------------------------------\n\n\n");

            userManager.Update(user1);
            userManager.Delete(user1);


            Console.ReadLine();
        }
    }
}
