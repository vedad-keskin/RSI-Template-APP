using System.Security.Cryptography;
using System.Text;

namespace Festify.Helper
{
    public class PasswordGenerator
    {
        public static string GenerateSalt()
        {
            byte[] salt = RandomNumberGenerator.GetBytes(32); // Increase salt size to 32 bytes
            return Convert.ToBase64String(salt);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            using (var sha256 = SHA256.Create()) // Use SHA256
            {
                byte[] combined = new byte[saltBytes.Length + passwordBytes.Length];
                Buffer.BlockCopy(saltBytes, 0, combined, 0, saltBytes.Length);
                Buffer.BlockCopy(passwordBytes, 0, combined, saltBytes.Length, passwordBytes.Length);

                byte[] hashBytes = sha256.ComputeHash(combined);
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
