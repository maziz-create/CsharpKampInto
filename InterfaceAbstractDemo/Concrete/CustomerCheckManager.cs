using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
//using InterfaceAbstractDemo.MernisServiceReference;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
