using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using LogicLayer;
using DataAccessLayer;
using ZooBazzarWebApp.DTO;

namespace ZooBazzarWebApp.Pages
{
    public class ComplaintModel : PageModel
    {
        private ComplaintsManager complaintsManager = new ComplaintsManager(new ComplaintsDB());
        private AccountManager accountManager = new AccountManager(new AccountManagerDB(), new AccountManagerDB());

        [BindProperty]
        public ComplaintDTO ComplaintDTO { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            try
            {
                Account author = accountManager.GetAccountByUsername(User.Identity.Name);
                Complaint complaint = new Complaint(author, ComplaintDTO.Title, ComplaintDTO.Description, DateTime.Now);
                complaintsManager.AddComplaint(complaint);
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
            }
                return Page();
        }
    }
}
