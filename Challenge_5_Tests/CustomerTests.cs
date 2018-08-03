using System;
using Challenge_5;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_5_Tests
{
    [TestClass]
    public class CustomerTests
    {
        CustomerRepository _customerRepo = new CustomerRepository();

        [TestMethod]
        public void CustomerRepository_GetList_CountShouldBeSame()
        {
            //Arrange
            List<CustomerClass> customers = _customerRepo.getList();
            //Act
            int actual = customers.Count;
            int expected = 3;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomerRepository_UpdateCustomers()
        {
            //Arrange
            CustomerClass updateCustomer = new CustomerClass("Adam", "Johnson", "Potential Customer", "We currently have the lowest rates on Helicopter Insurance!");
            _customerRepo.UpdateCustomer(updateCustomer);
            
        }
    }
}
