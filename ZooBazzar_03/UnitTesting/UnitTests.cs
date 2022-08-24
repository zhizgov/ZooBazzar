using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTesting
{
    [TestClass]
    public class UnitTests
    {
        private AccountManager accountManager = new AccountManager(new MockAccounts(), new MockAccounts());
        private EmployeeManagment employeeManagment = new EmployeeManagment(new MockEmployeeDB());

        [TestMethod]
        public void AddAccounts()
        {
            accountManager.AddAccount(new Account("Jikata", "1234"));

            Assert.IsTrue(accountManager.Accounts.Any(a => a.Username == "Jikata"));
        }

        [TestMethod]
        public void RemoveAccounts()
        {
            accountManager.AddAccount(new Account("Jikata", "1234"));
            accountManager.RemoveAccount(0);

            Assert.IsTrue(!accountManager.Accounts.Any(a => a.Username == "Jikata"));
        }

        [TestMethod]
        public void HashPassword()
        {
            string[] result;
            string salt = Guid.NewGuid().ToString();
            string password = "1234";

            result = new string[] { PasswordHasher.HashPassword(password + salt), salt };

            Assert.IsNotNull(result);
            Assert.AreNotEqual(password, result);
        }
        [TestMethod]
        public void GetAccountByCredentials()
        {
            accountManager.AddAccount(new Account("Jikata", "1234"));

            Assert.IsNotNull(accountManager.GetAccountByCredentials("Jikata", $"{PasswordHasher.HashPassword("1234"+ accountManager.Accounts[0].Salt)}"));
        }

        [TestMethod]
        public void AddEmployee()
        {
            employeeManagment.AddEmployee(new Employee(new Account("Peppa", "Pigg"), "Peppa", "The Pig", "In the barn", DateTime.Now, "peppa@abv.bg", "+359400500", "112", "88888","Manager"));
            
            Assert.IsTrue(employeeManagment.Employees.Any(a => a.Name == "Peppa"));
        }

        [TestMethod]
        public void GetCaretakersBySpecialization()
        {
            employeeManagment.AddEmployee(new Caretaker(new Account("Peppa", "Pigg"), "Peppa", "The Pig", "In the barn", DateTime.Now, "peppa@abv.bg", "+359400500", "112", "88888","Caretaker", Specialization.Mammalogist));
            employeeManagment.AddEmployee(new Caretaker(new Account("Peppa01", "Pigg"), "Peppa", "The Pig", "In the barn", DateTime.Now, "peppa@abv.bg", "+359400500", "112", "88888", "Caretaker", Specialization.Ichthyologist));
            employeeManagment.AddEmployee(new Caretaker(new Account("Peppa02", "Pigg"), "Peppa", "The Pig", "In the barn", DateTime.Now, "peppa@abv.bg", "+359400500", "112", "88888", "Caretaker", Specialization.Entomologist));
            employeeManagment.AddEmployee(new Caretaker(new Account("Peppa03", "Pigg"), "Peppa", "The Pig", "In the barn", DateTime.Now, "peppa@abv.bg", "+359400500", "112", "88888", "Caretaker", Specialization.Ornithologist));
            employeeManagment.AddEmployee(new Caretaker(new Account("Peppa04", "Pigg"), "Peppa", "The Pig", "In the barn", DateTime.Now, "peppa@abv.bg", "+359400500", "112", "88888", "Caretaker", Specialization.Mammalogist));

            Assert.IsFalse(employeeManagment.CaretakersBySpecialization(Specialization.Mammalogist).Any(c => c.GetSpecialization() != Specialization.Mammalogist));
        }

    }
}