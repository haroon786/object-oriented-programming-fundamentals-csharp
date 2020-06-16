using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetreiveValid()
        {
            var customerRespository = new CustomerRepository();
            var expected = new Customer(1)
            {
                
                EmailAddress = "haroon.ansari123@gmail.com",
                FirstName = "Haroon",
                LastName = "Ansari"
            };
            var actual = customerRespository.Retrieve(1);


            Assert.AreEqual(actual.CustomerId, expected.CustomerId);
            Assert.AreEqual(actual.FirstName, expected.FirstName);
            Assert.AreEqual(actual.LastName, expected.LastName);
            //Assert.AreEqual(expected, actual);
        }
    }
}
