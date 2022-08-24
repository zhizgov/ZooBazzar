using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IRequestDB<RequestedEmployee>
    {
        void Add(RequestedEmployee obj);


        void Delete(int id);


        List<RequestedEmployee> Read();

        void ChangeCredentials(RequestedEmployee obj);
    }
}
