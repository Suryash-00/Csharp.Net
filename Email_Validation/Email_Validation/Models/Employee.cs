using System.ComponentModel.DataAnnotations;

namespace Range_Validation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Fill the name you dumb!")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Write a proper name you idiot")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Are you gender-less?")]
        public string Gender { get; set; }
        
        [Required(ErrorMessage = "So you aren't borned.....")]
        [Range(10,50, ErrorMessage ="Bachche boodhe not allowed!")]
        public int? Age { get; set; }
        
        [Required(ErrorMessage = "Don't you know the email format?")]
        [EmailAddress]
        public string Email { get; set; }

    }
}