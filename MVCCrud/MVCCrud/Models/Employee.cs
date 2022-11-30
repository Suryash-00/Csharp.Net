using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCrud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        [Required]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string EmpCode { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string OfficeLocation { get; set; }
    }
}