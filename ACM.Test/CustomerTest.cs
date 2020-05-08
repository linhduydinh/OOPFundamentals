using System;
using ACM.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Tyler";
            customer.LastName = "Dinh";
            var stringExpected = "Tyler, Dinh";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(stringExpected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Dinh";
            var stringExpected = "Dinh";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(stringExpected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Tyler";
            var stringExpected = "Tyler";

            //Act
            var actual = customer.FullName;

            //Assert
            Assert.AreEqual(stringExpected, actual);
        }

        [TestMethod]
        public void StaticInstanceCountTest()
        {
            //Arrange 
            var customer1 = new Customer();
            customer1.LastName = "Dinh";
            Customer.InstanceCount += 1;

            var customer2 = new Customer();
            customer1.LastName = "Vo";
            Customer.InstanceCount += 1;

            var customer3 = new Customer();
            customer1.LastName = "Nguyen";
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);

        }

        [TestMethod]
        public void ValidateFirstNameAndLastNameValid()
        {
            var customer = new Customer()
            {
                FirstName = "Tyler",
                LastName = "Dinh"
            };

            //Act
            var expected = true;

            //Assert
            Assert.AreEqual(expected, customer.Validate());
        }

        [TestMethod]
        public void ValidateMissingFirstName()
        {
            var customer = new Customer()
            {
                LastName = "Dinh"
            };

            //Act
            var expected = false;

            //Assert
            Assert.AreEqual(expected, customer.Validate());
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            var customer = new Customer()
            {
                FirstName = "Tyler"
            };

            //Act
            var expected = false;

            //Assert
            Assert.AreEqual(expected, customer.Validate());
        }
    }
}
