using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
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

            string expected = "Ashish, Reddy";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);

        }
    }
}
