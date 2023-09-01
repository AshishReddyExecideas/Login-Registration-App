using System;
using Lacon.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lacon.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void StringHandlerTestValid()
        {
            //Arrange
            string source = "SonicScrewdriver";
            string expected = "Sonic Screwdriver";


            //Act
            string actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void StringHandlerTestNotValid()
        {
            //Arrange
            string source = "SonicScrewdriver";
            string expected = "SonicScrewdriver";

            //Act
            string actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
