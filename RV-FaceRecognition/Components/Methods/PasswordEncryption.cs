using System.Text;
using System.Security.Cryptography;

namespace RV_FaceRecognition.Components.Methods
{
    public class PasswordEncryption
    {
        public static string HashedPassword(string password)
        {
            MD5 md5 = MD5.Create();

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var c in hash)
                stringBuilder.Append(c.ToString("X2"));

            return stringBuilder.ToString();
        }
    }
}
