using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst.Models
{
    public class Employee       // Table name
    {
        [Key]       // Primary Key
        public int ID { get; set; }             // column name 1
        public string Name { get; set; }        // column name 2
        public string Gender { get; set; }      // column name 3
        public string Designation { get; set; } // column name 4
        public int Salary { get; set; }         // column name 5
    }
}
