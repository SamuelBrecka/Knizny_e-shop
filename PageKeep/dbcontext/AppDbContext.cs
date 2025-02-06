using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            base.OnModelCreating(modelBuilder);

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

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var admin = new UserAccount
            {
                Id = 1,
                Username = "admin",
                Email = "admin@example.com",
                PasswordHash = HashPassword("admin"), 
                Role = "Admin"
            };
            modelBuilder.Entity<UserAccount>().HasData(admin);
        }

        private string HashPassword(string password)
        {
            var _hasher = new PasswordHasher<UserAccount>();
            return _hasher.HashPassword(null, password);
        }
    }
}