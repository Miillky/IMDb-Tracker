using System;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using IMDbTrackerLibrary.Properties;

namespace IMDbTrackerLibrary {
    public static class Helpers {

        private const int Iterations = 10000;
        private const int SaltSize = 16; // 128 bit 
        private const int KeySize = 32; // 256 bit

        public static string HashPassword(string password) {
            using(Rfc2898DeriveBytes algorithm = new Rfc2898DeriveBytes(password, SaltSize, Iterations, HashAlgorithmName.SHA256)) {
                string key = Convert.ToBase64String(algorithm.GetBytes(KeySize));
                string salt = Convert.ToBase64String(algorithm.Salt);

                return $"{Iterations}.{salt}.{key}";
            }
        }

        public static bool CheckPassword(string hash, string password) {
            var parts = hash.Split('.');

            if(parts.Length != 3) {
                ResourceManager rm = new ResourceManager(typeof(ExceptionMessages));
                throw new FormatException(rm.GetString("HashFormat"));
            }

            int iterations = Convert.ToInt32(parts[0]);
            byte[] salt = Convert.FromBase64String(parts[1]);
            byte[] key = Convert.FromBase64String(parts[2]);

            using(Rfc2898DeriveBytes algorithm = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256)) {
                var keyToCheck = algorithm.GetBytes(KeySize);
                bool verified = keyToCheck.SequenceEqual(key);

                return verified;
            }
        }
    }
}
