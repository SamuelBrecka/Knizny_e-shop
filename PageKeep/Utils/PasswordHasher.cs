using Microsoft.AspNetCore.Identity;
using PageKeep.Models;

public static class PasswordHasher
{
    private static readonly PasswordHasher<UserAccount> _hasher = new PasswordHasher<UserAccount>();

    public static string HashPassword(string password)
    {
        return _hasher.HashPassword(null, password);
    }

    public static bool VerifyPassword(string hashedPassword, string providedPassword)
    {
        var result = _hasher.VerifyHashedPassword(null, hashedPassword, providedPassword);
        return result == PasswordVerificationResult.Success;
    }
}