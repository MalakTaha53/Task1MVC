using Microsoft.EntityFrameworkCore;
using Task1MVC.Models;

namespace Task1MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Task1MVC;Trusted_Connection=True;TrustServerCertificate=True");

        }
        public DbSet<Student> Students { get; set; }
    }
}
