using GameDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo2.Entities
{
    public class User : IUser
    {
        string _firstname, _lastname;
        public int Id { get; set; }
        public string IdentificationNumber { get; set; }
        public string FirstName
        {
            get { return _firstname.ToUpper(); }
            set { _firstname = value; }
        }
        public string LastName
        {
            get { return _lastname.ToUpper(); }
            set { _lastname = value; }
        }
        public DateTime DateOfBirth { get; set; }
    }
}
