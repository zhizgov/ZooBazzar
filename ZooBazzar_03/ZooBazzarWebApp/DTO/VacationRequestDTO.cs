using System.ComponentModel.DataAnnotations;


namespace ZooBazzarWebApp.DTO
{
    public class VacationRequestDTO
    {
        [Required(ErrorMessage = "Please select a start date")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage ="Please select an end date")]
        public DateTime EndDate { get; set; }
    }
}
