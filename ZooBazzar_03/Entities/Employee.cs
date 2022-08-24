using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Employee
    {
        //Fields
        private Account account;
        private string firstname;
        private string lastname;
        private string address;
        private DateTime birthdate;
        private string phone;
        private string email;
        private string emergencyContact;
        private string bsn;
        private string workposition;
        private int id;
        private List<EmployeeContract> contracts;

        public int Id { get { return id; } }
        public Account Account { get { return account; } }
        public string Name { get { return firstname; } }
        public string Lastname { get { return lastname; } }
        public string Address { get { return address; } }
        public DateTime Birthdate { get { return birthdate; } }
        public string Phone { get { return phone; } }
        public string EmargencyContact { get { return emergencyContact; } }
        public string Bsn { get { return bsn; } }
        public string Email { get { return email; } }
        public string WorkingPosition { get { return workposition; } }

        public List<EmployeeContract> Contracts { get { return this.contracts; } }

        //Constructor
        public Employee(Account account, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn,string workposition)
        {
            this.account = account;
            this.firstname = name;
            this.lastname = lastname;
            this.address = address;
            this.birthdate = birthdate;
            this.email = email;
            this.phone = phone;
            this.emergencyContact = emergencyContact;
            this.workposition = workposition;
            this.bsn = bsn;
            contracts = new List<EmployeeContract>();
        }
        public Employee(Account account, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn, string workposition,int id)
        {
            this.account = account;
            this.id = id;
            this.firstname = name;
            this.lastname = lastname;
            this.address = address;
            this.birthdate = birthdate;
            this.email = email;
            this.phone = phone;
            this.emergencyContact = emergencyContact;
            this.workposition = workposition;
            this.bsn = bsn;
            contracts = new List<EmployeeContract>();
        }
        public Employee(int id,string name)
        {
            this.id = id;
            this.firstname = name;
            this.contracts = new List<EmployeeContract>();
        }
       
        //Methods
        public void AssignContract(EmployeeContract ec)
        {
            contracts.Add(ec);
        }

        public override string ToString()
        {
            return $"{Name} {Lastname} - {WorkingPosition}";
        }
        public string GetNames()
        {
            return $"{Name}";
        }
    }
}
