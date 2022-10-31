using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace EFCore_CodeFirst.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            public DbSet<Employee> Employees { get; set; }
        }
    }
}