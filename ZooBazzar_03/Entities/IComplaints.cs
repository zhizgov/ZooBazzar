using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IComplaints<T>
    {
        public void AddComplaint(T complaint);
        public List<T> ReadComplaints();
    }
}
