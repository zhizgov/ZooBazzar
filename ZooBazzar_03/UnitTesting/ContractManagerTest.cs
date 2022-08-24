using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using LogicLayer;


namespace UnitTesting
{
    [TestClass]
    public class ContractManagerTest
    {
        [TestMethod]
        public void AddUserTest()
        {
            //arrange
            Account account = new Account(1, "username");
            Employee employee = new Employee(account, "name", "lastname", "adress",DateTime.Today.AddDays(17), "email@abv.bg", "02547995", "Nqma", "46464646", "Salesman");
            EmployeeContract contract = new EmployeeContract(1, DateTime.Today.AddDays(1), DateTime.Today.AddDays(366), 1, "reason", true);
            ContractsDBMock mc = new ContractsDBMock();
             ContractManager manager  = new ContractManager(mc);
            //act
            manager.AddContract(contract, employee);
            //assert
            Assert.AreEqual(1, manager.GetContracts().Count);
            Assert.AreEqual(1, contract.EmployeeId);
            Assert.AreEqual(DateTime.Today.AddDays(1), contract.StartDate);
            Assert.AreEqual(DateTime.Today.AddDays(366), contract.EndDate);
            Assert.AreEqual(1, contract.Fte);
            Assert.AreEqual("reason", contract.Reason);
            Assert.AreEqual(true, contract.IsValid);
        }

    }

}
