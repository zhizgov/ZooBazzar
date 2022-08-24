using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace LogicLayer
{
    public class ContractManager
    {
        private List<EmployeeContract> contracts;

        IContractDataManagement<EmployeeContract> contractDataManagement;
        public ContractManager(IContractDataManagement<EmployeeContract> contractDataManagement)
        {
            this.contractDataManagement = contractDataManagement;
            contracts = contractDataManagement.GetContracts();
            //GetContracts();
        }


        public void AddContract(EmployeeContract ec, Employee employee)
        {
            foreach (EmployeeContract employeeContract in contractDataManagement.GetContracts(employee))
            {
                if (employeeContract.IsValid == true)
                {
                    DisableContract(employeeContract);
                }
            }
            contractDataManagement.AddContract(ec, employee);
            employee.AssignContract(ec);
            contracts.Add(ec);
        }

        public void DisableContract(EmployeeContract ec)
        {
            contractDataManagement.DisableContract(ec);
        }

        public List<EmployeeContract> GetContracts()
        {
            return contracts;
        }

        public List<EmployeeContract> GetContracts(Employee e)
        {
            List<EmployeeContract> contracts = new List<EmployeeContract>();
            foreach (EmployeeContract ec in contractDataManagement.GetContracts(e))
            {
                e.AssignContract(ec);
                contracts.Add(ec);
            }
            return contracts;
        }

        public EmployeeContract GetActiveContract(Employee employee)
        {
            if (contracts.Any(x => x.EmployeeId == employee.Id && x.IsValid == true))
            {
                return contracts.First(x => x.EmployeeId == employee.Id && x.IsValid == true);
            }
            else
            {
                throw new Exception("The employee doesn't have an active contract");
            }
        }
        public void ReduceVacationDays(EmployeeContract contract, int days)
        {
            int daysLeft = contract.VacationDaysLeft - days;
            EmployeeContract c = new EmployeeContract(contract.Id, contract.EmployeeId, contract.StartDate, contract.EndDate, contract.Fte, contract.Reason, daysLeft, contract.IsValid);
            contractDataManagement.UpdateVacationDays(c);
        }

    }
}
