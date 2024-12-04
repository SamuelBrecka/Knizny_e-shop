using Microsoft.EntityFrameworkCore;
using PageKeep.Models;
using PageKeep.Models.Entities;

namespace PageKeep.dbcontext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<BookModel> Books { get; set; }

        public DbSet<UserAccount> Users { get; set; }


    }

}