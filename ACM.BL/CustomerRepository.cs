using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public  class CustomerRepository
    {

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EamilAddress = "haroon.ansari123@gmail.com";
                customer.FirstName = "Haroon";
                customer.LastName = "Ansari";
                customer.AddressList = addressRepository.RetreiveByCustomerId(customerId).ToList();
            }
            Object myobject = new Object();
            Console.WriteLine("object:{ myobject.ToString()}");
            return customer;

        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
