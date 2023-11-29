using System;
using System.Text;
using System.Security.Cryptography;

namespace RV_FaceRecognition.Components.Methods
{
    public class TokenGenerator
    {
        public static string GenerateRandomToken(int length)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var tokenBytes = new byte[length];
                rng.GetBytes(tokenBytes);
                return Convert.ToBase64String(tokenBytes);
            }
        }

        public static string ComputeSHA256Hash(string input)
        {
            using (var sha256 = new SHA256Managed())
            {
                var bytes = Encoding.UTF8.GetBytes(input);
                var hashedBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashedBytes);
            }
        }
    }
}
