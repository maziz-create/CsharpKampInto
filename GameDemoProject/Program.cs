using System;
using System.Collections.Generic;

namespace GameDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer gamer1 = new Customer() { FirstName = "Polat", LastName = "Alemdar", IdentityNumber = "12345678910", YearOfBirth = 1979 };
            SystemManager systemManager = new SystemManager();
            GameManager gameManager = new GameManager();
            int selection2 = 0; char selection3 = 'a';  //şu an için anlamsız
            systemManager.Login(gamer1);
            systemManager.HomePage(systemManager, gameManager, ref selection2, selection3);
            //Console.Read();            BUNU YAZMADAN GÖNDERME KODU GİTHUB'A
        }


        

    }
    
}
