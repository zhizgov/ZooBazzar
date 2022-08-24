using DataAccessLayer;
using Entities;
using LogicLayer;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MimeKit;
using MimeKit.Text;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Security.Claims;

namespace ZooBazzarWebApp.Pages
{
    public class BuyTicketModel : PageModel
    {
        [BindProperty]
        public TicketDTO Ticket { get; set; }

        [BindProperty]
        public NoCustomerAccountDTO Customer { get; set; }

        public CustomerManager cm = new CustomerManager(new CustomerDB());
        public TicketManager tm = new TicketManager(new TicketsDB(), new TicketsDB());
        private readonly IConfiguration _configuration;
        public void OnGet()
        {

        }

        public BuyTicketModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult OnPostWithAccount()
        {
            
                decimal price = 0;
                Customer customer = cm.GetCustomerByID(Convert.ToInt32(User.FindFirst("ID").Value));
                if (Ticket.Type == TypeOfTicket.adult)
                {
                    price = 8;
                }
                else if (Ticket.Type == TypeOfTicket.child)
                {
                    price = 6;
                }
                Ticket ticket = new Ticket(customer, Ticket.Type, Ticket.Date, PlaceOfPerchase.online, price);
                tm.AddTicket(ticket);

                return RedirectToPage("MyTickets");

            
        }

        public async Task<IActionResult> OnPostNoAccount()
        {
            if (ModelState.IsValid)
            {
                decimal price = 0;
                if (Ticket.Type == TypeOfTicket.adult)
                {
                    price = 8;
                }
                else if (Ticket.Type == TypeOfTicket.child)
                {
                    price = 6;
                }
                Ticket ticket = new Ticket(tm.GetNextID(),  null, Ticket.Type, Ticket.Date, PlaceOfPerchase.online, price);
                tm.AddTicket(ticket);
                await SendAsync(Customer.Name, Customer.Email, ticket);
                return RedirectToPage("Index");

            }
            return Page();
        }
        public async Task SendAsync(string name, string clientEmail, Ticket product)
        {
            string senderName = _configuration.GetSection("MailboxAddress").GetSection("Name").Value;
            string sender = _configuration.GetSection("MailboxAddress").GetSection("Address").Value;
            string password = _configuration.GetSection("MailboxAddress").GetSection("Password").Value;
            string username = _configuration.GetSection("MailboxAddress").GetSection("Username").Value;

            var messageToSend = new MimeMessage
            {
                Sender = new MailboxAddress(senderName, sender),
                Subject = "Zoo bazzar ticket",
            };
            if (messageToSend == null) throw new ArgumentNullException(nameof(messageToSend));
            messageToSend.Body = new TextPart(TextFormat.Html) { Text = $"Your zoo bazzar ticket with number {product.Id} made on {product.DateOfPurchase} " };
            messageToSend.From.Add(new MailboxAddress(senderName, sender));
            messageToSend.To.Add(new MailboxAddress(name, clientEmail)); //important!!


            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.MessageSent += (sender, args) =>
                {
                    Console.WriteLine(args.Response);
                };
                smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                await smtp.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTlsWhenAvailable);
                await smtp.AuthenticateAsync(sender, password);
                await smtp.SendAsync(messageToSend);
                await smtp.DisconnectAsync(true);
            };

        }


    }
}
