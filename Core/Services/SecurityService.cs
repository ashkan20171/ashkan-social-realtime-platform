using System;
using System.Security.Cryptography;

namespace AshkanSocial.Core.Services
{
    public static class SecurityService
    {
        public static void CreatePasswordHash(string password, out string hash, out string salt)
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create()) rng.GetBytes(saltBytes);
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000, HashAlgorithmName.SHA256))
            { salt = Convert.ToBase64String(saltBytes); hash = Convert.ToBase64String(pbkdf2.GetBytes(32)); }
        }
        public static bool Verify(string password, string hash, string salt)
        {
            try
            {
                byte[] saltBytes = Convert.FromBase64String(salt);
                byte[] expected = Convert.FromBase64String(hash);
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000, HashAlgorithmName.SHA256))
                {
                    byte[] actual = pbkdf2.GetBytes(32); if (actual.Length != expected.Length) return false;
                    int diff = 0; for (int i=0;i<actual.Length;i++) diff |= actual[i] ^ expected[i]; return diff == 0;
                }
            } catch { return false; }
        }
    }
}