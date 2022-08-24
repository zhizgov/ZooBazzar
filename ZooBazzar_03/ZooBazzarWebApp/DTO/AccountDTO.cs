using System.ComponentModel.DataAnnotations;

namespace ZooBazzarWebApp
{
    public class AccountDTO
    {
        [Required(ErrorMessage = "A valid email address is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "You need to fill your password to login.")]
        public string Password { get; set; }

    }
}
