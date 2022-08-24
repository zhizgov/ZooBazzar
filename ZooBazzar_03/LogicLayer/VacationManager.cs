using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace LogicLayer
{
    public class VacationManager
    {

        private EmployeeManagment employeeManager = new EmployeeManagment(new EmployeeDB());
        private ContractManager contractManager = new ContractManager(new ContractDB());
        private List<Vacation> vacations;

        public List<Vacation> Vacations { get { return vacations; } }
        private IVacations db;

        public VacationManager(IVacations db)
        {
            this.db = db;
        }

        public void ReadRequests()
        {
            if (vacations != null)
            {
                vacations.Clear();
            }
            vacations = db.ReadRequests();
        }

        public void ReadCurrentVacations()
        {
            if (vacations != null)
            {
                vacations.Clear();
            }
            vacations = db.ReadCurrentVacations();

        }

        public void RequestVacation(Vacation vacation)
        {
            Employee employee = employeeManager.GetEmployeeById(vacation.EmployeeID);
            EmployeeContract contract = contractManager.GetActiveContract(employee);
            
            if (!(Convert.ToInt32((vacation.EndDate.Date-vacation.StartDate.Date).TotalDays) <= contract.VacationDaysLeft))
            {
                throw new Exception($"This vacation is longer than your vacation limit! Vacation days left: {contract.VacationDaysLeft}");
            }
            db.RequestVacation(vacation);
        }

        public void AcceptVacation(Vacation vacation)
        {
            
            if (DateTime.Now.Date>vacation.StartDate.Date)
            {
                throw new Exception("You can only accept requests before their start date");
            }

            Employee employee = employeeManager.GetEmployeeById(vacation.EmployeeID);
            EmployeeContract contract = contractManager.GetActiveContract(employee);
            int vacationLength = Convert.ToInt32((vacation.EndDate.Date - vacation.StartDate.Date).TotalDays);
            contractManager.ReduceVacationDays(contract, vacationLength);
            db.AcceptVacation(vacation);
        }

        public void DenyVacation(Vacation vacation)
        {
            db.DenyVacation(vacation);
        }

        
    }
}
