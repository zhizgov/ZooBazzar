using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Subscription
    {
        //Fields
        private int id;
        private int customer_id;
        private DateTime startDate;
        private DateTime endDate;
        private TypeSubscription subscription;       

        public int Id { get { return id; } }
        public DateTime StartDate
        {
            get { return startDate; }
            private set
            {
                if (value.Date >= DateTime.Now.Date)
                {
                    startDate = value;
                }
                else
                {
                    throw new Exception("The start date should not be past date");
                }
            }
        }
        public DateTime EndDate { get { return endDate; } }
        public TypeSubscription SubscriptionType { get { return subscription; } }
        public int CustomerId { get { return customer_id; } }

        public Subscription(int custId,DateTime startDate, TypeSubscription type)
        {
            this.customer_id = custId;
            this.StartDate = startDate;
            this.subscription = type;
            this.endDate = type.CalculateEndDate(StartDate);
        }

        public Subscription(int id, int custId, DateTime startDate, DateTime endDate, TypeSubscription subscription)
        {
            this.id = id;
            this.customer_id = custId;  
            this.startDate = startDate;
            this.subscription = subscription;
            this.endDate = endDate;
            this.subscription = subscription; 
        }
    }
}
