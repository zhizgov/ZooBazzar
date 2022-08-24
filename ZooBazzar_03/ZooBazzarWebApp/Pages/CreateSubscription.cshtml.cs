using Entities;
using LogicLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazzarWebApp.Pages
{
    [Authorize(Roles = "Customer")]
    public class CreateSubscriptionModel : PageModel
    {
       
        private SubscriptionManager subscriptionManager;

        [BindProperty]
        public SubscriptonDTO DTO { get; set; }

        public CreateSubscriptionModel( SubscriptionManager sm)
        {         
            this.subscriptionManager = sm;
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
           subscriptionManager.Add( new Subscription(Convert.ToInt32(User.FindFirst("ID")?.Value),DTO.StartDate,TypeSubscription.GetTypesSubscription.Find(s => s.ToString() == DTO.Type)));
            ViewData["message"] = "A succsessfully created subscription!";

        }
    }
}
