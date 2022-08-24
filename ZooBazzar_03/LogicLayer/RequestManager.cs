using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace LogicLayer
{
    public class RequestManager
    {
        private List<RequestedEmployee> requestedEmployees;
        IRequestDB<RequestedEmployee> crud;
        public RequestManager(IRequestDB<RequestedEmployee> crud)
        {
            this.crud = crud;
            requestedEmployees = crud.Read();
        }

        public void Add(RequestedEmployee re)
        {
            crud.Add(re);
            requestedEmployees.Add(re);
        }

        public void Delete(RequestedEmployee re)
        {
            crud.Delete(re.Id);
            requestedEmployees.Remove(re);
        }


        public List<RequestedEmployee> Read()
        {
            return requestedEmployees;
        }
        public void ChangeCredentials(RequestedEmployee e)
        {
            crud.ChangeCredentials(e);
        }
    }
}
