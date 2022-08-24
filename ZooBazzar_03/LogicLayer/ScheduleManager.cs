using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace LogicLayer
{
    public class ScheduleManager
    {
        private static EmployeeManagment em;
        private static CageManager cm;
        private static ContractManager cmngr;
        private static VacationManager vm;

        static List<DailySchedule> dailySchedules = new List<DailySchedule>();
        public List<DailySchedule> DailySchedules { get { return dailySchedules; } }

        static List<DailySchedule> caretakerSchedule = new List<DailySchedule>();


        int fullShiftHours = 6;

        IScheduleDB<DailySchedule> crud;

        IAutoIncrementable autoIncr;

        public ScheduleManager(IScheduleDB<DailySchedule> crud, ICRU<Employee> employeeData, ICageDB<Cage> cageData, IContractDataManagement<EmployeeContract> contractData, IAutoIncrementable autoIncr)
        {
            this.crud = crud;
            em = new EmployeeManagment(employeeData);
            cm = new CageManager(cageData);
            cmngr = new ContractManager(contractData);
            this.autoIncr = autoIncr;
            //vm.ReadCurrentVacations();
        }


        private int GetWeekNumber(DateTime date, int index)
        {
            date = date.AddDays(index);
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
            return weekNum;
        }



        public void GetWeeklySchedule(DateTime date, int index)
        {
            bool match = false;

            if (dailySchedules != null)
            {
                match = dailySchedules.Any(ds => GetWeekNumber(date, index) == GetWeekNumber(DateTime.ParseExact(ds.Date, "dd MMM yyyy", null), 0));
            }

            if (!match)
            {
                dailySchedules.Clear();
                dailySchedules.AddRange(crud.Read(GUIHelper.GetWeek(date, index)));
            }

        }



        public List<Caretaker> GetCaretakers(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Mammal:
                    return em.CaretakersBySpecialization(Specialization.Mammalogist);
                    break;
                case AnimalType.Bird:
                    return em.CaretakersBySpecialization(Specialization.Ornithologist);
                    break;
                case AnimalType.Fish:
                    return em.CaretakersBySpecialization(Specialization.Ichthyologist);
                    break;
                case AnimalType.Insect:
                    return em.CaretakersBySpecialization(Specialization.Entomologist);
                    break;
                case AnimalType.Reptile:
                    return em.CaretakersBySpecialization(Specialization.Herprtologist);
                    break;
                case AnimalType.Amphibian:
                    return em.CaretakersBySpecialization(Specialization.Herprtologist);
                    break;
                default: throw new ArgumentException("IDk");

            }
        }

        public DailySchedule AssignedCaretakers(string time, string date, AnimalType type)
        {
            DailySchedule ds = dailySchedules.Find(ds => ds.TimeSlot == time && ds.Date == date && ds.Type == type);

            if (ds != null)
            {
                return ds;
            }

            return null;
        }

        public bool Insert(DailySchedule ds)
        {
            if (crud.Add(ds))
            {
                dailySchedules.Add(ds);
                return true;
            }
            return false;
        }

        public bool Update(DailySchedule ds)
        {
            if (crud.Update(ds))
            {
                int index = dailySchedules.FindIndex(x => x.Date == ds.Date && x.Type == ds.Type && x.TimeSlot == x.TimeSlot);

                dailySchedules[index] = ds;

                return true;
            }

            return false;

        }


        public List<Cage> GetCages(string feedingTime, AnimalType type, DateTime date)
        {
            List<Cage> allCages = cm.Cages;

            int day = (int)date.DayOfWeek;

            return allCages.FindAll(x => x.CageAnimals.Any(x => x.FeedingTimes.Any(x => x == feedingTime) && x.ReasonForDeparture == null && x.AnimalType == type && x.WeeklyFeedingIteration > day));
        }

        public int GetWorkedHours(Caretaker caretaker)
        {

            int fullShifts = dailySchedules.FindAll(ds => ds.MainCaretakerFir.Id == caretaker.Id || ds.MainCaretakerSec.Id == caretaker.Id).Count * fullShiftHours;

            fullShifts += dailySchedules.FindAll(ds => ds.HelpCaretaker != null).FindAll(ds => ds.HelpCaretaker.Id == caretaker.Id).Count * fullShiftHours;

            return fullShifts;
        }

        public List<Caretaker> GetFreeCaretakers(AnimalType type, string date, string timeSlot)
        {
            List<Caretaker> caretakers = GetCaretakers(type);

            List<Caretaker> freeCaretakers = new List<Caretaker>();

            //Removes the caretakers that are currently on vacation
            //foreach (Vacation vacation in vm.Vacations)
            //{
            //    caretakers.Remove(caretakers.Find(x => x.Account.Id == vacation.EmployeeID));
            //}

            foreach (Caretaker caretaker in caretakers)
            {
                cmngr.GetContracts(caretaker);

                if ((caretaker.Contracts.Find(c => c.IsValid == true).Fte * 40) >= (GetWorkedHours(caretaker) + fullShiftHours))

                {
                    freeCaretakers.Add(caretaker);
                }
            }

            DailySchedule ds = AssignedCaretakers(timeSlot, date, type);

            if (ds != null)
            {
                if (!freeCaretakers.Any(x => x.Id == ds.MainCaretakerFir.Id))
                {
                    freeCaretakers.Add(ds.MainCaretakerFir);
                }
                if (!freeCaretakers.Any(x => x.Id == ds.MainCaretakerSec.Id))
                {
                    freeCaretakers.Add(ds.MainCaretakerSec);
                }

                if (ds.HelpCaretaker != null)
                {
                    if (!freeCaretakers.Any(x => x.Id == ds.HelpCaretaker.Id))
                    {
                        freeCaretakers.Add(ds.HelpCaretaker);
                    }
                }
            }

            return freeCaretakers;
        }


        public List<DailySchedule> GetCaretakerSchedule(Caretaker caretaker, DateTime date, int index)
        {
            GetWeeklySchedule(date, index);

            caretakerSchedule = dailySchedules.FindAll(s => s.MainCaretakerFir.Id == caretaker.Id || s.MainCaretakerSec.Id == caretaker.Id);
            caretakerSchedule.AddRange(dailySchedules.FindAll(x => x.HelpCaretaker != null).FindAll(x => x.HelpCaretaker.Id == caretaker.Id));

            caretakerSchedule.Sort((x, y) => DateTime.ParseExact(x.Date, "d MMM yyyy", null).CompareTo(DateTime.ParseExact(y.Date, "d MMM yyyy", null))); 

            return caretakerSchedule;
        }

        public int GetId()
        {
            return autoIncr.GetNexID();
        }

    }
}
