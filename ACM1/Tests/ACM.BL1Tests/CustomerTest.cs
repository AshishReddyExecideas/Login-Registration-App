using ACM.BL1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BL1Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Ashish",
                LastName = "Reddy"
            };

            String expected = "Reddy, Ashish";

            String actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {

            Customer customer = new Customer
            {
                LastName = "Reddy"
            };
            string expected = "Reddy";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        public void FullNameLastNameEmpty()
        {

            Customer customer = new Customer
            {
                FirstName = "Ashish"
            };
            string expected = "Ashish";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Ashish";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Sujith";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Mukund";
            Customer.InstanceCount += 1;


            Assert.AreEqual(3, Customer.InstanceCount); 
        }

        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Reddy",
                EmailAddress = "ashishreddy@gmail.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName() 
        {
            var customer = new Customer
            {
                EmailAddress = "ashishreddy@gmail.com"
            };

            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
