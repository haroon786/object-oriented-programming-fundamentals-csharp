using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag Ford";
                address.StreetLine2 = "Bagshot row";
                address.City = "HObbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "133";
            }
            return address;
        }
        public IEnumerable<Address> RetreiveByCustomerId(int CustomerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag Ford",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "shire",
                Country = "MIddle Earth",
                PostalCode = "122"

            };
            addressList.Add(address);
            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "MIddle Earth",
                PostalCode = "12"

            };
            addressList.Add(address);
            return addressList;

        }
        public bool Save(Address address)
        {
            return true;
        }


    }
}
