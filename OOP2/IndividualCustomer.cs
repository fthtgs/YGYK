using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Miras - Inheritance method Class-name:SubClass-name
    // Ortak özellikler SubClass-name barındırılır farklı olanlar için ayrı class kullanılır.
    class IndividualCustomer:Customer
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
