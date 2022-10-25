using System.ComponentModel.DataAnnotations;

namespace Validation_Summary.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Fill the name you dumb!")]
        //[StringLength(30, MinimumLength = 5, ErrorMessage = "Write a proper name you idiot")]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Are you gender-less?")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "So you aren't borned.....")]
        [Range(10, 50, ErrorMessage = "Bachche boodhe not allowed!")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Don't you know the email format?")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password toh daalo bhai")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Please use strong password, consisting of 8 characters containing at least one uppercase, one lowercase and one special character")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Url]
        public string ChannelURL { get; set; }
    }
}