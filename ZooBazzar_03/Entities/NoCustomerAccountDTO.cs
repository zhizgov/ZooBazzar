using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class NoCustomerAccountDTO
    {
        [Required(ErrorMessage ="Please enter your name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email!")]
        public string Email { get; set; }
    }
}
