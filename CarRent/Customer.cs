using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent
{
    public class Customer
    {
        public string SocialSecurityNumber
        {
            get;
        }

        public Customer(String ssn)
        {
            SocialSecurityNumber = ssn;
        }
    }
}
