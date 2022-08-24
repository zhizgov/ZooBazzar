using Entities;


namespace LogicLayer
{
    public class TicketManager
    {
        //Fields
        private ICRU<Ticket> crud;
        private IAutoIncrementable auto;
        private List<Ticket> tickets;
        public IList<Ticket> Tickets { get { return tickets.AsReadOnly(); } }

        //Constructor
        public TicketManager(ICRU<Ticket> crud,IAutoIncrementable auto)
        {
            this.auto = auto;
            this.crud = crud;
            tickets = crud.Read();
        }

        //Methods
        public void AddTicket(Ticket ticket)
        {
            //Ticket temp = new Ticket(auto.GetNexID(), ticket.Customer, ticket.TypeOfTicket, ticket.Date, ticket.PlaceOfPerchase, ticket.Price);
            //tickets.Add(temp);
            //crud.Add(temp);
            tickets.Add(ticket);
            crud.Add(ticket);
        }


        public int GetNextID()
        {
           return auto.GetNexID();

        }

        public void UseTicket(Ticket t)
        {
            crud.Update(t);

        }

        public List<Ticket> GetTickets(Customer c)
        {
            List<Ticket> tickets = new List<Ticket>();
            foreach (Ticket t in this.tickets)
            {
                if (t.Customer.Id == c.Id)
                {
                    tickets.Add(t);
                }
            }
            return tickets;
        }

        public Ticket GetTicket(int id)
        {
            return tickets.Find(x => x.Id == id);
        }
        public bool ChangeTicketStatus(Ticket t)
        {
            if (t.IsUsed == true)
            {
                return false;
            }
            t.UseTicket();
            crud.Update(t);
            return true;
        }


    }
}
