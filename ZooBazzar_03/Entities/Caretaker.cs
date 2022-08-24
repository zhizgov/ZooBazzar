using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Caretaker : Employee
    {
        private Specialization specialization;
        public Caretaker(Account account, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn,string? workposition,Specialization specialization) : base(account, name, lastname, address, birthdate, email, phone, emergencyContact, bsn,workposition)
        {
            this.specialization = specialization;
            workposition = "Caretaker";
        }
        public Caretaker(Account account, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn, string? workposition,int id, Specialization specialization) : base(account, name, lastname, address, birthdate, email, phone, emergencyContact, bsn, workposition,id)
        {
            this.specialization = specialization;
            workposition = "Caretaker";
        }
        public Caretaker(int id, string name, Specialization specialization) : base(id,name)
        {
            this.specialization= specialization;
        }
        
        public Specialization GetSpecialization()
        {
            return specialization;
        }

        public override string ToString()
        {
            return $"{base.ToString()}({specialization})";
        }
       
    }
}
