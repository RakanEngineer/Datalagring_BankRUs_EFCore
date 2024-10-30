using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Datalagring_BankRUs_EFCore.Models
{
    class Customer
    {
        public Customer(string firstName, string lastName, string socialSecurityNumber, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            Address = address;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        public Address Address { get; }
    }
}
