using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class GetDataFromUser
    {
        public GetDataFromUser(Customer gamer1)
        {
            gamer1.FirstName = Console.ReadLine();
            gamer1.LastName = Console.ReadLine();
            gamer1.IdentityNumber = Console.ReadLine();
            gamer1.YearOfBirth = Convert.ToInt32(Console.ReadLine());
        }
    }
}
