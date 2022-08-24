using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLayer;
using DataAccessLayer;
using Entities;
using ZooBazzarWebApp.DTO;

namespace ZooBazzarWebApp.Pages
{
    public class RequestVacationModel : PageModel
    {
        private VacationManager vacationManager = new VacationManager(new VacationsDB());

        private VacationRequestDTO request = new VacationRequestDTO();

        [BindProperty]
        public VacationRequestDTO Request { get { return request; } set { request = value; } }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            try
            {
                Vacation vacation = new Vacation(Convert.ToInt32(User.FindFirst("ID").Value), User.Identity.Name, Request.StartDate, Request.EndDate);
                vacationManager.RequestVacation(vacation);
                return Page();
            }
            catch (Exception ex)
            {
                return Page();
            }
        }
    }
}
