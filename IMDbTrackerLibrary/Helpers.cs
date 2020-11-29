using System;
using System.Security.Cryptography;

namespace IMDbTrackerLibrary {
    public static class Helpers {

        public static string CreateSalt() {
            var rng = new RNGCryptoServiceProvider();
            var buffer = new byte[GlobalConfig.hashLength];
            rng.GetBytes(buffer);

            return Convert.ToBase64String(buffer);
        }

        public static string GenerateSha256Hash(string password, string salt) {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password + salt);
            SHA256Managed shaString = new SHA256Managed();
            byte[] hash = shaString.ComputeHash(bytes);

            return BitConverter.ToString(hash);
        }

        public static string GeneratePsswordHash(string password, string salt) {
            return GenerateSha256Hash(password, salt).Replace("-", string.Empty).Substring(0, GlobalConfig.hashLength);
        }
    }
}
