using Attendance_MAnagement_System.Models.Dao;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Attendance_MAnagement_System.Data
{
    public class ApplicationDBContext: IdentityDbContext<Employee>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Leave> leaves { get; set; }
    }
}
