using Entities;

namespace LogicLayer
{
    public static class GUIHelper
    {
        public static List<string> GetWeek(DateTime pickDate, int index)
        {
            List<string> daysInWeek = new List<string>();

            var now = pickDate;
            var currentDay = now.DayOfWeek;
            int days = (int)currentDay;

            DateTime sunday = now.AddDays(-days);

            for (int i = 0; i < 7; i++)
            {
                DateTime day = sunday.AddDays(i + index);


                string date = $"{day.Day} {day.ToString("MMM")} {day.Year}";

                daysInWeek.Add(date);
            }

            return daysInWeek;
        }


        
    }
}
