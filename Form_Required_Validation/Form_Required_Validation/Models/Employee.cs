using System.ComponentModel.DataAnnotations;

namespace Form_Required_Validation.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Fill the name you dumb!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Are you gender-less?")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "So you aren't borned.....")]
        public int? Age { get; set; }
    }
}