using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using WinFormsApp1.Domain.Models;

namespace WinFormsApp1.Infastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WinFormsAppDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
