using System.ComponentModel.DataAnnotations;

namespace String_Length_Validation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Fill the name you dumb!")]
        [StringLength(30, MinimumLength =5, ErrorMessage ="Write a proper name you idiot")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Are you gender-less?")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "So you aren't borned.....")]
        public int? Age { get; set; }
    }
}