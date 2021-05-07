using GameDemo2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo2.Abstract
{
    public interface IUserManagerService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
