using System.Security.Cryptography;
using System.Text;

namespace Core.Helper.Helper;

public static class SecurityHelper
{
    public static string HashPassword(string password, string salt)
    {
        // if you wan't add peper please add password with peper
        const int iterations = 100000;
        const int keySize = 32;
        var saltBytes = Encoding.UTF8.GetBytes(salt);
        using var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, iterations, HashAlgorithmName.SHA256);
        var hashBytes = pbkdf2.GetBytes(keySize);
        return Convert.ToBase64String(hashBytes);
    }

    public static string GenerateSalt()
        => StringHelper.GeneratorRandomStringBase64(12);
    public static bool VerifyPassword(string password, string salt, string passwordHash)
        => HashPassword(password, salt).Equals(passwordHash);
}