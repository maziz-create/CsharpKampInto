using System;

namespace GameDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Users user1 = new Users()
            {
                Id = 1,
                IdentificationNumber = "12345",
                FirstName = "Polat",
                LastName = "Alemdar",
                DateOfBirth = 1998

            };
            IEStateVerificationService eStateVerificationManager = new EStateVerificationManager();
            eStateVerificationManager.Verification(user1);
        }
    }
    class Users
    {
        string _firstname, _lastname;
        public int Id { get; set; }
        public string IdentificationNumber { get; set; }
        public string FirstName {
            get { return _firstname.ToUpper(); }
            set { _firstname = value;  } 
        }
        public string LastName {
            get { return _lastname.ToUpper(); }
            set { _lastname = value; }
        }
        public int DateOfBirth { get; set; }
    }
    interface IUserManagerService
    {
        void Add(Users user);
        void Update(Users user);
        void Delete(Users user);
    }
    class UserManager : IUserManagerService
    {
        public void Add(Users user)
        {
            Console.WriteLine("E Devlet doğrulaması başarılı! "+user.FirstName +" "+ user.LastName + " İsimli Kullanıcı Eklendi.");
        }

        public void Update(Users user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " İsimli Kullanıcı Güncellendi!");
        }
        public void Delete(Users user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " İsimli Kullanıcı Silindi.");
        }
    }
    interface IEStateVerificationService
    {
        void Verification(Users user);
    }
    class EStateVerificationManager : IEStateVerificationService
    {
        string _firstname = "POLAT", _lastname = "ALEMDAR", _identificationnumber = "12345";
        int _dateofbirth = 1998;
        public void Verification(Users user)
        {
            if (user.IdentificationNumber==_identificationnumber && user.FirstName == _firstname && user.LastName == _lastname && user.DateOfBirth == _dateofbirth)
            {
                IUserManagerService userManager = new UserManager();
                userManager.Add(user);
            }
        }
    }
}
