using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IStatistics
    {
        public Dictionary<int, int> GetTicketSales(string filter, string place, string filter2, int value);

        public Dictionary<int, double> GetIncome(string filter, string filter2, int value);

        public Dictionary<int, int> GetPeople();
        public Dictionary<int, int> GetVisitorsLive();

        public Dictionary<int, int> GetVisitors(string filter1, string filter2, int value);


    }
}
