using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using EFCodeFirst.Models;

namespace EFCodeFirst.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)   // options=> database provider; base is to call constructor of the base c
        {
            public DbSet<Employee> Employees{ get; set; }
        }
        public DbSet<EFCodeFirst.Models.Employee> Employee { get; set; }
    }
}