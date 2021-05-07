using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    class MernisVerification
    {
        string MernisIdentityNumber = "12345678910";
        string MernisFirstName = "Polat";
        string MernisLastName = "Alemdar";
        int MernisBirth = 1979;

        public MernisVerification(Customer gamer1, ref int verification)
        {
            if (gamer1.IdentityNumber==MernisIdentityNumber && gamer1.FirstName == MernisFirstName && gamer1.LastName == MernisLastName && gamer1.YearOfBirth == MernisBirth)
            {
                verification = 1;
            }
        }
    }
}
