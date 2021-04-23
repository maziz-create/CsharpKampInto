using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer:Customer    //bireysel hesap  //: inheritance
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
    }
}
