using System.ComponentModel.DataAnnotations;

namespace EFCore_CodeFirst.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }
}