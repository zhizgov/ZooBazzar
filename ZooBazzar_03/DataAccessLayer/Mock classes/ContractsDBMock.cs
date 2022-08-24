using MySql.Data.MySqlClient;
using Entities;
using System.Data;

namespace DataAccessLayer
{
    public class ContractsDBMock : IContractDataManagement<EmployeeContract>
    {
        public void AddContract(EmployeeContract ec, Employee e)
        {

        }

        public void DisableContract(EmployeeContract ec)
        {

        }

        public List<EmployeeContract> GetContracts()
        {
            return new List<EmployeeContract>();
        }

        public List<EmployeeContract> GetContracts(Employee e)
        {
            return new List<EmployeeContract>();
        }

        public void UpdateVacationDays(EmployeeContract contract)
        {

        }
    }
}
