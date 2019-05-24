using System.ComponentModel.DataAnnotations;

namespace Assignment_06.Models
{
    public class BdCard
    {
        [Required(ErrorMessage ="Please enter From")]
        public string From { get; set; }
        [Required(ErrorMessage = "Please enter To")]
        public string To { get; set; }
        [Required(ErrorMessage = "Please enter Message")]
        public string Message { get; set; }
    }
}