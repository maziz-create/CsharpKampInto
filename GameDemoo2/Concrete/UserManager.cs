using GameDemo2.Abstract;
using GameDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo2.Concrete
{
    public class UserManager : IUserManagerService
    {
        public void Add(User user)
        {
            Console.WriteLine("E Devlet doğrulaması başarılı! " + user.FirstName + " " + user.LastName + " isimli kullanıcı sisteme giriş yaptı.");
        }
        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcı sistemde güncellendi.");
        }
        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcı sistemden silindi.");
        }
    }
}
