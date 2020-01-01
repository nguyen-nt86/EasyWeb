using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace EasyWeb.Common
{
    public class Common
    {
        public string GeneratePassword(string password)
        {
            byte[] salt = GenerateSalt();
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashedPassword;

        }
        public bool ValidatePassword(string password)
        {
            return true;
        }
        private byte[] GenerateSalt()
        {
            byte[] salt = new byte[128 / 8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
            //return Convert.ToBase64String(salt);
        }
    }
}
