using GameDemo2.Abstract;
using GameDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo2.Concrete
{
    public class EStateVerificationManager : IEStateVerificationService
    {

        string _firstname = "POLAT", _lastname = "ALEMDAR", _identificationnumber = "12345";
        int _dateofbirth = 1998;
        public void Verification(User user)
        {
            if (user.IdentificationNumber == _identificationnumber && user.FirstName == _firstname && user.LastName == _lastname && user.DateOfBirth.Year == _dateofbirth)
            {
                IUserManagerService userManager = new UserManager();
                userManager.Add(user);
            }
            else
            {
                Console.WriteLine("E-Devlet Doğrulaması Hatalı!");
                throw new Exception("Not a valid person");
            }
        }
    }
}
