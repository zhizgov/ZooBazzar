using System.ComponentModel.DataAnnotations;

namespace ZooBazzarWebApp.DTO
{
    public class ComplaintDTO
    {
        [Required(ErrorMessage ="Please fill in a title")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please fill in a description")]
        public string Description { get; set; }
    }
}
