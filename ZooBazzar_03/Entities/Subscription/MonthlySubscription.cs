using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MonthlySubscription : TypeSubscription
    {
        public override DateTime CalculateEndDate(DateTime startDate)
        {
            return startDate.AddMonths(1);
        }

        public override decimal GetPrice()
        {
            return 60m;
        }

        public override string ToString()
        {
            return "MonthlySubscription";
        }
    }
}
