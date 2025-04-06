using Microsoft.EntityFrameworkCore;
using simplyBooksBE.Models;

namespace simplyBooksBE.Data
{
    public class simplyBooksBEDbContext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }

        public simplyBooksBEDbContext(DbContextOptions<simplyBooksBEDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>().HasData(AuthorsData.Author);
            modelBuilder.Entity<Books>().HasData(BooksData.Book);

            modelBuilder.Entity<Authors>()
                .HasMany(a => a.Book)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.Author_Id);

            modelBuilder.Entity<Books>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Book)
                .HasForeignKey(b => b.Author_Id);
        }
    }
}
