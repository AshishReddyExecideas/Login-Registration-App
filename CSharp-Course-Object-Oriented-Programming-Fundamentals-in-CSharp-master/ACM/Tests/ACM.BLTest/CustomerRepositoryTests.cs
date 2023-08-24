using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTests
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
               
                EmailAddress = "george.calin@gmail.com",
                FirstName = "George",
                LastName = "Calin"
            };


            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);

        }
    }
}
