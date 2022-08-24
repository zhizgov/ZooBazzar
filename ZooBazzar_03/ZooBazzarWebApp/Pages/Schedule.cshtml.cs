using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazzarWebApp.Pages
{
    [Authorize]
    public class ScheduleModel : PageModel
    {
        public static Employee currentEmployee;
        private List<DailySchedule> schedules;
        public static List<string> ShiftInfo = new List<string>();

        private ScheduleManager scheduleManager;
        private EmployeeManagment employeeManagment;

        public static List<string> WeekDays;


        static int index;

        public ScheduleModel(ScheduleManager sm,EmployeeManagment em)
        {
            scheduleManager = sm;
            employeeManagment = em;
            
        }
        public void OnGet()
        {
            currentEmployee = employeeManagment.AllCaretakers().Find(e => e.Id == Convert.ToInt32(User.FindFirst("ID").Value));
            index = 0;
            schedules = scheduleManager.GetCaretakerSchedule((Caretaker)currentEmployee, DateTime.Now, index);
            WeekDays = GUIHelper.GetWeek(DateTime.Today, index);
        }

        public List<Cage> getCages(DailySchedule ds)
        {
            return scheduleManager.GetCages(ds.TimeSlot, ds.Type, DateTime.ParseExact(ds.Date, "d MMM yyyy", null));
        }
        
        private List<DailySchedule> GetShifts(string time)
        {
            return schedules.FindAll(x => x.TimeSlot == time);
        }

        public DailySchedule GetShift(string time, int date)
        {
            return GetShifts(time).Find(x => (int)DateTime.ParseExact(x.Date, "dd MMM yyyy", null).DayOfWeek == date);
        }

        public List<string> GetShiftInfo(DailySchedule ds)
        {
            if (ds == null)
            {
                ShiftInfo = new List<string>();
            }
            else
            {
                List<Cage> cages = getCages(ds);
                

                ShiftInfo.Add($"First main caretaker: {ds.MainCaretakerFir.Name}\r\n");
                ShiftInfo.Add($"Second main caretaker: {ds.MainCaretakerSec.Name}\r\n");
                ShiftInfo.Add($"Helper caretaker: {ds.HelpCaretaker.Name}\r\n");
                ShiftInfo.Add($"Cages: \r\n");
                foreach (Cage cage in cages)
                {
                    ShiftInfo.Add($"Cage nr: {cage.CageNumber}      Animal specie: {cage.GetSpecie()}\r\n");
                }
            }
            return ShiftInfo;
        }

        public IActionResult OnPost(string button)
        {
            if (button == "Previous week")
            {
                index -= 7;
                schedules = scheduleManager.GetCaretakerSchedule((Caretaker)currentEmployee, DateTime.Now, index);
                WeekDays = GUIHelper.GetWeek(DateTime.Today, index);
                return Page();
            }
            else if(button == "Next week")
            {
                index += 7;
                schedules = scheduleManager.GetCaretakerSchedule((Caretaker)currentEmployee, DateTime.Now, index);
                WeekDays = GUIHelper.GetWeek(DateTime.Today, index);
                return Page();
            }
            else
            {
                schedules = scheduleManager.GetCaretakerSchedule((Caretaker)currentEmployee, DateTime.Now, index);

                DailySchedule ds = schedules.Find(x => x.Id == Convert.ToInt32(button));
                GetShiftInfo(ds);

                WeekDays = GUIHelper.GetWeek(DateTime.Today, index);
                return Page();
            }
        }
      
    }
}
