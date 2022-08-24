using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;


namespace UnitTesting
{
    [TestClass]
    public class ContractsTest
    {
        [TestMethod]
        public void ContractConstructorWithValidData()
        {

            EmployeeContract contract = new EmployeeContract(1, DateTime.Today.AddDays(1), DateTime.Today.AddDays(366), 1, "reason", true);
            // Assert.IsNotNull(user);
            Assert.AreEqual(1, contract.EmployeeId);
            Assert.AreEqual(DateTime.Today.AddDays(1), contract.StartDate);
            Assert.AreEqual(DateTime.Today.AddDays(366), contract.EndDate);
            Assert.AreEqual(1, contract.Fte);
            Assert.AreEqual("reason", contract.Reason);
            Assert.AreEqual(true, contract.IsValid);
        }

        [TestMethod]
        public void ContractConstructorWrongEndDate()
        {
            Assert.ThrowsException<Exception>(() =>
           new EmployeeContract(1, DateTime.Today.AddDays(2), DateTime.Today.AddDays(1), 1, "reason", true));
        }

        [TestMethod]
        public void ContractConstructorZeroFte()
        {
            Assert.ThrowsException<Exception>(() =>
           new EmployeeContract(1, DateTime.Today.AddDays(2), DateTime.Today.AddDays(369), -1, "reason", true));
        }

        [TestMethod]
        public void ContractConstructorMoreThanFte()
        {
            Assert.ThrowsException<Exception>(() =>
           new EmployeeContract(1, DateTime.Today.AddDays(2), DateTime.Today.AddDays(369), 2, "reason", true));
        }

    }

}
