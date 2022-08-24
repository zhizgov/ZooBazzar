using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer.Mock_classes;
using System;
using System.Linq;

namespace UnitTesting
{
    [TestClass]
    public class VacationsUnitTesting
    {
        private VacationManager vacationManager = new VacationManager(new VacationDBMock());
        [TestMethod]
        public void RequestVacation()
        {
            Vacation vacation = new Vacation(4, "Test", DateTime.Now, DateTime.Now.AddDays(30));

            Exception ex = Assert.ThrowsException<Exception>(() => vacationManager.RequestVacation(vacation));
            Assert.AreEqual("This vacation is longer than your vacation limit! Vacation days left: 20", ex.Message);
        }

        [TestMethod]
        public void AcceptVacation()
        {
            Vacation vacation = new Vacation(4, "Test", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(7));

            Exception ex = Assert.ThrowsException<NotImplementedException>(() => vacationManager.RequestVacation(vacation));
            Assert.AreEqual("The method or operation is not implemented.", ex.Message);
        }
    }
}
