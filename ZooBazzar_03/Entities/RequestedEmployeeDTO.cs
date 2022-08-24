using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RequestedEmployeeDTO
    {
        [Required(ErrorMessage="Name is required")]
        public string Name {get;set;}

        [Required(ErrorMessage = "Last Name is required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Adress is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Emergency contact is required")]
        public string EmargencyContact { get; set; }

        [Required(ErrorMessage = "BSN is required")]
        public string Bsn { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}
