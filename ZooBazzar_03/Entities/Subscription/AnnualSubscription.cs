using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AnnualSubscription : TypeSubscription
    {
        public override DateTime CalculateEndDate(DateTime startDate)
        {
            return startDate.AddYears(1);
        }

        public override decimal GetPrice()
        {
            return 170m;
        }

        public override string ToString()
        {
            return "AnnualSubscription";
        }
    }
}
