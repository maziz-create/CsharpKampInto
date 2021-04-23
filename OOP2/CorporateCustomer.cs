using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer:Customer     //şirket hesabı, tüzel müşteri // corporatecustomerin ebeveyni customer oluyor. customerde var olan tüm özellikler corporatecustomerde de mevcut. 
    {      
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }   //vergi no
    }
}
