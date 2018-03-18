using System;

namespace CarRent
{
    public class Customer
    {
        public String SocialSecurityNumber { get; }
        public String FullName { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }

        public Customer(String ssn)
        {
            SocialSecurityNumber = ssn;
        }
    }
}
