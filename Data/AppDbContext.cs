
using EfcorePractice.Models;
using Microsoft.EntityFrameworkCore;
namespace EfcorePractice.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Students> Students { get; set; }
    }
}
