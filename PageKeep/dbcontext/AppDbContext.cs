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

            // Konfigurácia zloženého primárneho kľúča pre BookGenreModel
            modelBuilder.Entity<BookGenreModel>()
                .HasKey(bg => new { bg.BookId, bg.GenreId });

            // Konfigurácia vzťahov pre BookGenreModel
            modelBuilder.Entity<BookGenreModel>()
                .HasOne(bg => bg.Book)
                .WithMany(b => b.BookGenres)
                .HasForeignKey(bg => bg.BookId);

            modelBuilder.Entity<BookGenreModel>()
                .HasOne(bg => bg.Genre)
                .WithMany(g => g.BookGenres)
                .HasForeignKey(bg => bg.GenreId);
        }
    }
}