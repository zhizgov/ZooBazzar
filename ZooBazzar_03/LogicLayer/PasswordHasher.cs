using System.Security.Cryptography;
using System.Text;

namespace LogicLayer
{
    public class PasswordHasher
    {
        public static string HashPassword(string value)
        {
            SHA256 hash = SHA256.Create();           
            byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(value));

            string hashedpassword = BitConverter.ToString(bytes).Replace("-", "").ToLower();

            return hashedpassword;
        }
    }
}
