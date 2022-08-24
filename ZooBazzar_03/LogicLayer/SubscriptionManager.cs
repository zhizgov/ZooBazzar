using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace LogicLayer
{
    public class SubscriptionManager
    {
        private ISubscription sub;
        public SubscriptionManager(ISubscription subscription)
        {
            this.sub = subscription;  
        }

        public void Add(Subscription subscription)
        {
            if (subscription == null)
                throw new ArgumentNullException();

            sub.Add(subscription);
        }

        public List<Subscription> GetSubscriptions(int custId)
        {
            if(custId < 0)
                throw new ArgumentOutOfRangeException();

            return sub.GetSubscriptions(custId);
        }
    }
}
