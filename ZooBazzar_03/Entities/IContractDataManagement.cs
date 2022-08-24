using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IContractDataManagement<EmployeeContract>
    {
        void AddContract(EmployeeContract ec, Employee e);

        void DisableContract(EmployeeContract ec);

        List<EmployeeContract> GetContracts();
        List<EmployeeContract> GetContracts(Employee e);
        public void UpdateVacationDays(EmployeeContract contract);
    }
}
