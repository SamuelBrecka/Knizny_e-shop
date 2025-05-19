using Microsoft.AspNetCore.Identity;
using PageKeep.Models;

namespace PageKeep.Utils;

public static class PasswordHasher
{
    private static readonly PasswordHasher<UserAccount> Hasher = new PasswordHasher<UserAccount>();

    public static string HashPassword(string password)
    {
        return Hasher.HashPassword(null!, password);
    }

    public static bool VerifyPassword(string? hashedPassword, string providedPassword)
    {
        if (hashedPassword != null)
        {
            var result = Hasher.VerifyHashedPassword(null!, hashedPassword, providedPassword);
            return result == PasswordVerificationResult.Success;
        }

        return false;
    }
}