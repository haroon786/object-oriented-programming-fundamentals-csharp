using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; set; }
        public int CustomerType { get; set; }
        public string EamilAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public override string ToString() =>FirstName;

        public string FullName
        {
            get
           {
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {   if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ",";
                    }
                    fullname += FirstName;
                }
                return fullname;
            }
        }
        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        //public Customer Retrieve(int customerId)
        //{
        //    return new Customer();
        //}
        //public List<Customer> Retrieve()
        //{
        //    return new List<Customer>();
        //}


    }
}
