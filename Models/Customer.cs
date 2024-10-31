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
        public int Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string SocialSecurityNumber { get; protected set; }
        public Address Address { get; protected set; }
        public Customer()
        {
            
        }

        public Customer(string firstName, string lastName, string socialSecurityNumber, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            Address = address;
        }
        //public Customer(string firstName, string lastName, string socialSecurityNumber, Address address)
        //    : this(firstName,lastName,socialSecurityNumber)
        //{
        //      Address = address;
        //}
       
    }
}
