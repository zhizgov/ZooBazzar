using Entities;
using System.ComponentModel.DataAnnotations;

namespace ZooBazzarWebApp
{
    public class SubscriptonDTO
    {
        [Required(ErrorMessage = "A valid start date is required.")]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "A valid type is required.")]
        public string Type { get; set; }
    }
}
