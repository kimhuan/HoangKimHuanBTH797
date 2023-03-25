using Microsoft.EntityFrameworkCore;
using BaiThucHanh2003.Models;

namespace BaiThucHanh2003.Data
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