using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EmployeeContract
    {
        private int id;
        private int employeeId;
        private DateTime startDate;
        private DateTime endDate;
        private double fte;
        private string reason;
        private bool isValid;
        private int vacationDaysLeft;





        public int Id { get { return this.id; } }
        public int EmployeeId { get { return this.employeeId; } }
        public DateTime StartDate { get { return this.startDate; } }

        public DateTime EndDate
        {
            get { return this.endDate; }
            private set
            {
                if (value.CompareTo(startDate) < 0)
                {
                    throw new Exception("End date cannot be after the start date!");
                }
                this.endDate = value;
            }
        }

        public double Fte
        {
            get { return this.fte; }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("FTEs cannot be less than 0!");
                }
                if (value > 1)
                {
                    throw new Exception("FTEs cannot be more than 1!");
                }
                this.fte = value;
            }
        }
        public string Reason { get { return this.reason; } }
        public bool IsValid { get { return this.isValid; } }
        public int VacationDaysLeft { get { return this.vacationDaysLeft; } }

        public EmployeeContract(int id,int employeeId, DateTime startDate, DateTime endDate, double fte, string reason, int vacationDaysLeft, bool isValid)
        {
            this.id = id;
            this.employeeId = employeeId;
            this.startDate = startDate;
            this.endDate = endDate;
            this.fte = fte;
            this.reason = reason;
            this.vacationDaysLeft = vacationDaysLeft;
            this.isValid = isValid;
        }

        public EmployeeContract(int employeeId, DateTime startDate, DateTime endDate, double fte, string reason, bool isValid)
        {
            this.employeeId = employeeId;
            this.startDate = startDate;
            this.EndDate = endDate;
            this.Fte = fte;
            this.reason = reason;
            this.isValid = isValid;
        }

        



        public override string ToString()
        {
            return $"Start Date: {StartDate} End Date: {EndDate} FTE: {fte}  Reason: {Reason}";
        }
    }
}

