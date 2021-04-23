using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class Customer
    {
        private string _firstName;
        public string FirstName { get { return "Mr. " + _firstName; } set { _firstName = value; } }

     
    }
}
