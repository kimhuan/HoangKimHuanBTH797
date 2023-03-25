using Microsoft.EntityFrameworkCore;
using HoangKimHuanBTH.Models;

namespace HoangKimHuanBTH.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base (options)
        {

        }

        public DbSet<Student> Student {get; set;}
    }
}