using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RequestedEmployee
    {
        private string firstname;
        private string lastname;
        private string address;
        private DateTime birthdate;
        private string phone;
        private string email;
        private string emergencyContact;
        private string bsn;
        private int id;

        public string Name { get { return firstname; } }
        public string Lastname { get { return lastname; } }
        public string Address { get { return address; } }
        public DateTime Birthdate { get { return birthdate; } }
        public string Phone { get { return phone; } }
        public string EmargencyContact { get { return emergencyContact; } }
        public string Bsn { get { return bsn; } }
        public string Email { get { return email; } }
        public int Id { get { return id; } set { id = value; } }

        public RequestedEmployee(int id, string name, string lastname, string address, DateTime birthdate, string email, string phone, string emergencyContact, string bsn)
        {
            this.id = id;
            this.firstname = name;
            this.lastname = lastname;
            this.address = address;
            this.birthdate = birthdate;
            this.email = email;
            this.phone = phone;
            this.emergencyContact = emergencyContact;
            this.bsn = bsn;
        }



        public RequestedEmployee(int id, string name)
        {
            this.id = id;
            this.firstname = name;
        }

        public override string ToString()
        {
            return $"Name: {Name} Last Name: {Lastname} Email: {Email} Adress: {Address} Birth Date: {Birthdate} Phone: {Phone} EC: {EmargencyContact} BSN: {Bsn}";
        }
    }
}
