using BookManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookManagement.infrastructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired().HasMaxLength(100);
        //    modelBuilder.Entity<Book>().Property(b => b.Author).IsRequired().HasMaxLength(100);
        //}
    }
}
