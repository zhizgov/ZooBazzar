using Entities;

namespace DataAccessLayer 
{
    public class ScheduleDBMock : IScheduleDB<DailySchedule>, IAutoIncrementable
    {
        public bool Add(DailySchedule ds)
        {
            return true;
        }

        public int GetNexID()
        {
            throw new NotImplementedException();
        }

        public List<DailySchedule> Read(List<string> days)
        {
            return new List<DailySchedule>();
        }

        public bool Update(DailySchedule ds)
        {
            return true;
        }
    }
}
