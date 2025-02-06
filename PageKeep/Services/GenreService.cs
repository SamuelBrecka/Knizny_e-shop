using Microsoft.EntityFrameworkCore;
using PageKeep.dbcontext;
using PageKeep.Models;

namespace PageKeep.Services
{
    public class GenreService
    {
        private readonly AppDbContext _dbContext;

        public List<GenreModel> Genres { get; private set; } = new();

        public GenreService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<GenreModel>> GetGenresAsync()
        {
            return Genres = await _dbContext.Genres.ToListAsync();
        }
    }
}
