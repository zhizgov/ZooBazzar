using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface ITicketDB
    {
        List<Ticket> GetTickets();
        void ChangeTicketStatus(Ticket t);
        Customer GetCustomer(string email);

    }
}
