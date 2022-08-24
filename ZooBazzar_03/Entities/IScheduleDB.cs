using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IScheduleDB<DailySchedule>
    {
        bool Add(DailySchedule ds);

        List<DailySchedule> Read(List<string> days);

        bool Update(DailySchedule ds);
    }
}
