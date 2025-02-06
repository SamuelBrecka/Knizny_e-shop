using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PageKeep.Models.Entities;

namespace PageKeep.dbcontext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BookModel> Books { get; set; }
        public DbSet<UserAccount> Users { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }
        public DbSet<GenreModel> Genres { get; set; }
        public DbSet<BookGenreModel> BookGenres { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookGenreModel>()
                .HasKey(bg => new { bg.BookId, bg.GenreId });

            modelBuilder.Entity<BookGenreModel>()
                .HasOne(bg => bg.Book)
                .WithMany(b => b.BookGenres)
                .HasForeignKey(bg => bg.BookId);

            modelBuilder.Entity<BookGenreModel>()
                .HasOne(bg => bg.Genre)
                .WithMany(g => g.BookGenres)
                .HasForeignKey(bg => bg.GenreId);
            modelBuilder.Entity<ReviewModel>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserAccount>()
                .HasData(new UserAccount
                {
                    Id = 1,
                    Username = "admin",
                    Email = "admin@example.com",
                    PasswordHash = "AQAAAAIAAYagAAAAEM9S18EOtAcXhbTAyAl6gL7axczRp0lddLJ3lDfO1Jl0kjU45oGaTVg3/NDT3Z2A8Q==",
                    Role = "Admin"
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}