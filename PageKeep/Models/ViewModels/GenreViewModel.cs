using Microsoft.EntityFrameworkCore;
using PageKeep.dbcontext;

namespace PageKeep.Models.ViewModels
{
    public class GenreViewModel
    {
        private readonly AppDbContext _dbContext;

        public List<GenreModel> Genres { get; private set; } = new();

        public GenreViewModel(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<GenreModel>> GetGenresAsync()
        {
            return Genres = await _dbContext.Genres.ToListAsync();
        }
    }
}
