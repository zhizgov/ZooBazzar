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
    public class ScheduleTesting
    {
        ScheduleManager sm = new ScheduleManager(new ScheduleDBMock(), new MockEmployeeDB(), new CageDBMock(), new ContractsDBMock(), new ScheduleDBMock());
        EmployeeManagment em = new EmployeeManagment(new MockEmployeeDB());
        CageManager cm = new CageManager(new CageDBMock());


        [TestMethod]
        public void TestGetCurrentWeek()
        {
            //Getting a day from the week, which days i want to retrieve
            DateTime date = DateTime.ParseExact("11 May 2022", "d MMM yyyy", null);

            //Creating a list with the days of the week that starts at 8 May(sunday) and ends on 14 May(saturday)
            List<string> dates = GUIHelper.GetWeek(date, 0);

            //Creating manually a list with the days of the week starting from 8 May and ending on 14 May
            List<string> weeks = new List<string>();
            weeks.Add("8 May 2022");
            weeks.Add("9 May 2022");
            weeks.Add("10 May 2022");
            weeks.Add("11 May 2022");
            weeks.Add("12 May 2022");
            weeks.Add("13 May 2022");
            weeks.Add("14 May 2022");

            CollectionAssert.AreEquivalent(dates, weeks);
        }


        [TestMethod]
        public void CreateDailyScheduleWrongData()
        {
            DailySchedule ds;
            GetTestEmployees();
            List<Caretaker> employees = em.AllCaretakers();

            Assert.ThrowsException<Exception>(() => ds = new DailySchedule(1, AnimalType.Mammal, "10 May 2022", employees[1], employees[3], employees[2], "evening"));
        }

        public List<DailySchedule> GetTestSchedule()
        {
            sm.DailySchedules.Clear();
            //em.GetEmployees().Clear();  

            GetTestEmployees();

            List<Caretaker> employees = em.AllCaretakers();    


            DailySchedule ds1 = new DailySchedule(1, AnimalType.Mammal, "10 May 2022", employees[0], employees[3], employees[2], "evening");
            DailySchedule ds2 = new DailySchedule(2, AnimalType.Mammal, "11 May 2022", employees[0], employees[3], employees[2], "evening");
            DailySchedule ds3 = new DailySchedule(3, AnimalType.Mammal, "10 May 2022", employees[0], employees[2], null, "morning");

            //Creating list with all the daily initialised daily schedules^
            List<DailySchedule> schedules = new List<DailySchedule>();
            schedules.Add(ds1);
            schedules.Add(ds2);
            schedules.Add(ds3);

            for (int i = 0; i < schedules.Count; i++)
            {
                sm.Insert(schedules[i]);
            }

            return schedules;
        }

        public void GetTestEmployees()
        {
            em.AddEmployee(new Caretaker(1, "Radka", Specialization.Mammalogist));
            em.AddEmployee(new Caretaker(2, "Pandu", Specialization.Ornithologist));
            em.AddEmployee(new Caretaker(3, "Peza", Specialization.Mammalogist));
            em.AddEmployee(new Caretaker(4, "Stoil", Specialization.Mammalogist));
            em.AddEmployee(new Caretaker(5, "Marto", Specialization.Entomologist));

            for (int i = 0; i < em.AllCaretakers().Count; i++)
            {
                em.AllCaretakers()[i].Contracts.Add(new EmployeeContract(i, DateTime.Now, DateTime.Now, 0.5, "why not", true));
            }
        }


        [TestMethod]
        public void TestInsertDailySchedule()
        {
            DailySchedule ds = new DailySchedule(1, AnimalType.Mammal, "12 May 2022", new Caretaker(6, "Neshto", Specialization.Mammalogist), new Caretaker(7, "Nishto", Specialization.Mammalogist), null, "noon");

            Assert.IsTrue(sm.Insert(ds));


            Assert.IsTrue(sm.DailySchedules.Contains(ds));


        }

        [TestMethod]
        public void TestGetAssignedCaretakers()
        {
            List<DailySchedule> schedules = GetTestSchedule();
            DailySchedule s = schedules[1];


            DailySchedule ds = sm.AssignedCaretakers(s.TimeSlot, s.Date, s.Type);

            Assert.AreEqual(s.MainCaretakerFir, ds.MainCaretakerFir);
            Assert.AreEqual(s.MainCaretakerSec, ds.MainCaretakerSec);

        }

        [TestMethod]
        public void TestUpdateSchedule()
        {
            List<DailySchedule> schedules = GetTestSchedule();

            DailySchedule editedSchedule = new DailySchedule(1, AnimalType.Mammal, "10 May 2022", new Caretaker(4, "felicia", Specialization.Mammalogist), new Caretaker(1, "Radka", Specialization.Mammalogist), new Caretaker(3, "Peza", Specialization.Mammalogist), "morning");

            //Updating the caretakers where the date, time slot and type of animals match (the third record in the list) in the manager class
            sm.Update(editedSchedule);

            Assert.AreNotEqual(schedules[2], editedSchedule);
            CollectionAssert.AreNotEquivalent(schedules, sm.DailySchedules);

        }

        [TestMethod]
        public void TestGetWeeklySchedule()
        {
            //Getting the mock data with 3 daily schedules
            GetTestSchedule();

            //Reading the data 
            
            sm.GetWeeklySchedule(DateTime.ParseExact("12 May 2022", "d MMM yyyy", null), 0);
            Assert.AreEqual(3, sm.DailySchedules.Count);
            sm.GetWeeklySchedule(DateTime.ParseExact("17 May 2022", "d MMM yyyy", null), 0);
            Assert.AreEqual(0, sm.DailySchedules.Count);
        }

        [TestMethod]
        public void TestGetCaretakers()
        {
            GetTestSchedule();

            Assert.AreEqual(3, sm.GetCaretakers(AnimalType.Mammal).Count);
            Assert.AreEqual(1, sm.GetCaretakers(AnimalType.Bird).Count);
            Assert.AreEqual(1, sm.GetCaretakers(AnimalType.Insect).Count);
        }

        [TestMethod]
        public void TestGetCages()
        {
            Animal animal1 = new Animal("1", 1, Diet.Carnivore, AnimalType.Mammal, "Tiger", 4);
            Animal animal2 = new Animal("2", 1, Diet.Carnivore, AnimalType.Mammal, "Tiger", 4);
            Animal animal3 = new Animal("3", 1, Diet.Carnivore, AnimalType.Mammal, "Tiger", 4);

            animal1.FeedingTimes.Add("evening");
            animal2.FeedingTimes.Add("evening");
            animal3.FeedingTimes.Add("evening");

            Cage tigerCage = new Cage(1);

            tigerCage.CageAnimals.Add(animal1);
            tigerCage.CageAnimals.Add(animal2);
            tigerCage.CageAnimals.Add(animal3);

            cm.Cages.Add(tigerCage);

            List<Cage> cages = sm.GetCages("evening", AnimalType.Mammal, DateTime.ParseExact("17 May 2022", "d MMM yyyy", null));

            Assert.AreEqual(1, cages.Count);

            cages = sm.GetCages("evening", AnimalType.Mammal, DateTime.ParseExact("21 May 2022", "d MMM yyyy", null));

            Assert.AreEqual(0, cages.Count);
        }


        [TestMethod]
        public void TestGetWorkedHours()
        {
            GetTestSchedule();

            Assert.AreEqual(18, sm.GetWorkedHours(em.GetCaretakerById(1)));
            Assert.AreEqual(12, sm.GetWorkedHours(em.GetCaretakerById(4)));
            Assert.AreEqual(0, sm.GetWorkedHours(em.GetCaretakerById(5)));
        }

        [TestMethod]
        public void TestGetFreeCaretakers()
        {
            GetTestSchedule();

            //Checking for available employees(who have not worked their weekly hours)
            Assert.AreEqual(1, sm.GetFreeCaretakers(AnimalType.Mammal, "12 May 2022", "morning").Count);

            //Checking for available employees(if they have assigned shifts the same day, but they have worked their weekly hours, they still appear as available)
            Assert.AreEqual(3, sm.GetFreeCaretakers(AnimalType.Mammal, "10 May 2022", "evening").Count);

            //Checking for available employees the next work week
            sm.GetWeeklySchedule(DateTime.ParseExact("19 May 2022", "d MMM yyyy", null), 0);
            Assert.AreEqual(3, sm.GetFreeCaretakers(AnimalType.Mammal, "19 May 2022", "evening").Count);
        }

        [TestMethod]
        public void TestGetCaretakerSchedule()
        {
            GetTestSchedule();

            //Checking the working days for a given caretaker by given day of a certain work week
            Assert.AreEqual(2, sm.GetCaretakerSchedule(em.GetCaretakerById(4), DateTime.ParseExact("12 May 2022", "d MMM yyyy", null), 0).Count);
        }
    }
}
