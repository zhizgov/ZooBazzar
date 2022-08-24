using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer.Mock_classes
{
    public class VacationDBMock : IVacations
    {
        public void AcceptVacation(Vacation vacation)
        {
            throw new NotImplementedException();
        }

        public void DenyVacation(Vacation vacation)
        {
            throw new NotImplementedException();
        }

        public List<Vacation> ReadCurrentVacations()
        {
            return new List<Vacation>();
        }

        public List<Vacation> ReadRequests()
        {
            return new List<Vacation>();
        }

        public void RequestVacation(Vacation vacation)
        {
            throw new NotImplementedException();
        }
    }
}
