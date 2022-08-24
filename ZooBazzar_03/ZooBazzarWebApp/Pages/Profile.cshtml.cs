using DataAccessLayer;
using Entities;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace ZooBazzarWebApp.Pages
{
    public class ProfileModel : PageModel
    {
        public EmployeeManagment em;
        private CustomerManager customerManager;
        private SubscriptionManager subscriptionManager;

        public Employee? Employee { get; set; }
        public Customer? Customer { get; set; }
        public Subscription? Subscription { get; set; }

        public ProfileModel(EmployeeManagment em,CustomerManager cm, SubscriptionManager sm)
        {
            this.em = em;
            this.customerManager = cm;
            this.subscriptionManager = sm;
        }

        public void OnGet()
        {
            int id = Convert.ToInt32(User.FindFirst("ID")?.Value);


            Employee = em.Employees.FirstOrDefault(e => e.Id == id);
            this.Customer = customerManager.GetCustomer(id);
            Subscription = subscriptionManager.GetSubscriptions(id).FindLast(s => s.EndDate >= DateTime.Now);

        }
    }
}
