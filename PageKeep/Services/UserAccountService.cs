using PageKeep.dbcontext;
using PageKeep.Models;
using PageKeep.ViewModels;

namespace PageKeep.Services
{
    public class UserAccountService
    {
        private readonly AppDbContext _dbContext;

        public UserAccountService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task RegisterUserAsync(string username, string email, string hashedPassword, RegisterViewModel Model)
        {
            var newUser = new UserAccount
            {
                Username = Model.UserName,
                Email = Model.Email,
                PasswordHash = hashedPassword,
                Role = "User"
            };

            _dbContext.Users.Add(newUser);
            await _dbContext.SaveChangesAsync();
        }

        public bool IsUserRegistered(string email, string username)
        {
            var existingUser = _dbContext.Users.FirstOrDefault(u => u.Username == username || u.Email == email);
            return existingUser != null;
        }

        public Task<UserAccount?> GetUserByNameAsyc(string? username)
        {
            return Task.FromResult(_dbContext.Users.Where(i => i.Username == username).FirstOrDefault());
        }
    }
}
