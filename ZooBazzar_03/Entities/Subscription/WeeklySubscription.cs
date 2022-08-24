using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WeeklySubscription : TypeSubscription
    {
        public override DateTime CalculateEndDate(DateTime startDate)
        {
            return startDate.AddDays(7);
        }

        public override decimal GetPrice()
        {
            return 30m;
        }
        public override string ToString()
        {
            return "WeeklySubscription";
        }
    }
}
