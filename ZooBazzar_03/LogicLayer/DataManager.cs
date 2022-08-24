using DataAccessLayer;

namespace LogicLayer
{
    public class DataManager
    {
        private static AccountManager accountManager = new AccountManager(new AccountManagerDB(),new AccountManagerDB());
        private static AnimalManager animalManager = new AnimalManager(new AnimalDB(), new AnimalDB());
        private static CageManager cageManager = new CageManager(new CageDB());
        private static ContractManager contractManager = new ContractManager(new ContractDB());
        private static EmployeeManagment employeeManagment = new EmployeeManagment(new EmployeeDB());

        public static AccountManager AccountManager { get { return accountManager; } }
        public static AnimalManager AnimalManager { get { return animalManager; } }
        public static CageManager CageManager { get { return cageManager; } }
        public static ContractManager ContractManager { get { return contractManager; } }
        public static EmployeeManagment EmployeeManagment { get { return employeeManagment; } }
    }
}
