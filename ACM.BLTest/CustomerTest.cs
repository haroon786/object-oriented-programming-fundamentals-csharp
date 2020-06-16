using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer cust = new Customer
            {
                FirstName = "bilbo",
                LastName = "baigans"
            };

            string expected = "baigans,bilbo";
            string actual = cust.FullName;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void LastNameTestValid()
        {
            Customer cust = new Customer
            {
                FirstName = "bilbo"
                
            };

            string expected = "bilbo";
            string actual = cust.FullName;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FirstNameTestValid()
        {
            Customer cust = new Customer
            {
                LastName = "baigans"

            };

            string expected = "baigans";
            string actual = cust.FullName;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
               
        }
        [TestMethod]
        public void ValidateValid()
        {
            var c1 = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggin@hobbit.com"
            };
            var expected = true;
            var actual = c1.Validate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingName()
        {
            var c1 = new Customer
            {
                EmailAddress = "fbaggin@hobbit.com"
            };
            var expected = false;
            var actual = c1.Validate();
            Assert.AreEqual(expected, actual);
        }


    }
}
