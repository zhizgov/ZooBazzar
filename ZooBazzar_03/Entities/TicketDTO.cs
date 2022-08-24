using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TicketDTO
    {
        public TypeOfTicket Type { get; set; }
        public PlaceOfPerchase PlaceOfPerchase { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public decimal Price { get; set; }
    }
}
