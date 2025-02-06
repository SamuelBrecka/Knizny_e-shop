using PageKeep.dbcontext;
using PageKeep.Models;

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

        public async Task<UserAccount> GetUserByNameAsyc(string username)
        {
            return _dbContext.Users.Where(i => i.Username == username).FirstOrDefault();
        }
    }
}
