using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalagring_BankRUs_EFCore.Models
{
    class Address
    {
        public Address(string street, string city, string postcode)
        {
            Street = street;
            City = city;
            Postcode = postcode;
        }

        public string Street { get; }
        public string City { get; }
        public string Postcode { get; }
        public int CustomerId { get; }
        public Customer Customer { get; }
    }
}
