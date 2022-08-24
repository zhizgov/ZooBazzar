using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface ISubscription
    {
        public void Add(Subscription obj);
        public List<Subscription> GetSubscriptions(int customerId);
    }
}
