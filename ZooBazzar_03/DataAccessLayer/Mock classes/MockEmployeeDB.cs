using Entities;

namespace DataAccessLayer
{
    public class MockEmployeeDB : ICRU<Employee>
    {
        public void Add(Employee obj)
        {
          
        }

        public List<Employee> Read()
        {
            return new List<Employee>();
        }

        public void Update(int id, Employee obj)
        {
            
        }

        public void Update(Employee obj)
        {
           
        }
    }
}
