using Microsoft.EntityFrameworkCore;
using BaiThucHanh1004.Models;
namespace BaiThucHanh1004.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base (options)
        {

        }

        public DbSet<Student> Student {get; set;}

        public DbSet<Employee> Employee {get; set;}
    }
}