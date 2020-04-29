using System;
using System.Collections.Generic;
using System.Text;

namespace UserForTest
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            addressId = addressId;
        }

        public int addressId { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string streetline1 { get; set; }
        public string streetline2 { get; set; }

        public bool validate()
        {
            var isValid = true;
            if (PostalCode == null) isValid = false;
            return isValid;
        }

    }
}
