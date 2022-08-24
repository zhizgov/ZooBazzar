using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface ICustomerDB
    {
        Customer GetCustomer(int id);

        List<Customer> GetCustomers();
    }
}
