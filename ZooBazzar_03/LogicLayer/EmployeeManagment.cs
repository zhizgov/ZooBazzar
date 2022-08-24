using Entities;


namespace LogicLayer
{
    public class EmployeeManagment
    {
        public delegate void ChangedEmployeeEventHandler();
        public event ChangedEmployeeEventHandler ChangedEmployee;


        private static List<Employee> employees = new List<Employee>();
        private ICRU<Employee> crud;
        public IList<Employee> Employees { get { return employees.AsReadOnly(); } } 

        public EmployeeManagment(ICRU<Employee> crud)
        {
            this.crud = crud;
            employees = crud.Read();
        }

        public Caretaker GetCaretakerById(int id)
        {
            return AllCaretakers().Find(c => c.Id == id);
        }

        
        public bool AddEmployee(Employee employee)
        {
            if(employees == null)
                employees = new List<Employee>();

            if (!employees.Any(e => e == employee))
            {
                crud.Add(employee);
                employees.Add(employee);            
                return true;
            }
            return false;
        }       
        
        public List<Caretaker> AllCaretakers()
        {
            List<Caretaker> result = new List<Caretaker>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is Caretaker)
                {
                    result.Add((Caretaker)employees[i]);
                }
            }
            return result;
        }
        public List<Caretaker> CaretakersBySpecialization(Specialization specialization)
        {
            List<Caretaker> result = new List<Caretaker>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i] is Caretaker)
                {
                    Caretaker caretaker = (Caretaker)employees[i];
                    if(caretaker.GetSpecialization() == specialization)
                    {
                       result.Add(caretaker);
                    }
                }
            }
            return result;
        }

          
        public void UpdateEmployee(Employee employee)
        {
            
            if(employee != null)
            {
                crud.Update(employee);
                employees[employees.FindLastIndex(e => employee.Id == employee.Id)] = employee;            

            }
            
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.Find(x => x.Id == id);
        }
    }
}
