using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void FullNameValid()
        {
            //-- Arrange
            Customer customer = new Customer()
            {
                FirstName = "George",
                LastName = "Calin"
            };

            string expected = "George, Calin";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer()
            {
                FirstName = "George",

            };

            string expected = "George";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer()
            {

                LastName = "Calin"
            };

            string expected = "George, Calin";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void InstanceCountTest()
        {
            //-- Arrange
            Customer c1 = new Customer();
            c1.FirstName = "George";
            Customer.InstanceCount += 1;

            Customer c2 = new Customer();
            c1.FirstName = "Alex";
            Customer.InstanceCount += 1;

            Customer c3 = new Customer();
            c1.FirstName = "Cornel";
            Customer.InstanceCount += 1;

            //-- Act


            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);

        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            Customer c1 = new Customer();
            c1.LastName = "George";
            c1.EmailAddress = "george.calin@gmail.com";
            bool expected = true;

            //Act
            bool actual = c1.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateNotValid()
        {
            //Arrange
            Customer c1 = new Customer()
            {
                EmailAddress = "george.calin@gmail.com"
            };
            bool expected = false;

            //Act
            bool actual = c1.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}