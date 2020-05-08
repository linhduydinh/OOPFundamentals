using ACM.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {

        [TestMethod]
        public void RetrieveCustomerValid()
        {
            //Arrange
            var customerRepositoty = new CustomerReposistory();
            var expected = new Customer(1)
            {
                FirstName = "Tyler",
                LastName = "Dinh"
            };

            //Act
            var actual = customerRepositoty.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        }

    }
}
