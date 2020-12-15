using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using IMDbTrackerLibrary.Properties;

namespace IMDbTrackerLibrary {
    public static class Helpers {

        public static string HashPassword(string password) {
            using(Rfc2898DeriveBytes algorithm = new Rfc2898DeriveBytes(password, GlobalConfig.PasswordHashSaltSize, GlobalConfig.PasswordHashIterations, HashAlgorithmName.SHA256)) {
                string key = Convert.ToBase64String(algorithm.GetBytes(GlobalConfig.PasswordHashKeySize));
                string salt = Convert.ToBase64String(algorithm.Salt);
                string itterationsIdentifier = GetIdentifierFromItterations(GlobalConfig.PasswordHashIterations);

                return $"{itterationsIdentifier}${salt}${key}";
            }
        }

        public static bool CheckPassword(string hash, string password) {
            var parts = hash.Split('$');

            if(parts.Length != 3) {
                ResourceManager rm = new ResourceManager(typeof(ExceptionMessages));
                throw new FormatException(rm.GetString("HashFormat"));
            }

            int iterations = GetItterrationsFromIdentifier(parts[0]);
            byte[] salt = Convert.FromBase64String(parts[1]);
            byte[] key = Convert.FromBase64String(parts[2]);

            using(Rfc2898DeriveBytes algorithm = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256)) {
                var keyToCheck = algorithm.GetBytes(GlobalConfig.PasswordHashKeySize);
                bool verified = keyToCheck.SequenceEqual(key);

                return verified;
            }
        }

        private static string GetIdentifierFromItterations(int itterations) {
            string itterationsIdentifier = "VM1";

            switch(itterations) {
                case 10000:
                    itterationsIdentifier = "VM2";
                    break;
            }
            return itterationsIdentifier;
        }

        private static int GetItterrationsFromIdentifier(string itterationsIdentifier) {
            int itterations = 1000;

            switch(itterationsIdentifier) {
                case "VM2":
                    itterations = 10000;
                    break;
            }
            return itterations;
        }

        public static void ShowMessageBox(string messageName) {
            MessageBox.Show(GlobalConfig.GetMessageBoxMessages(messageName));
        }

        public static int GeneratePasswordResetCode() {
            Random rnd = new Random();
            return rnd.Next(100000, 999999);
        }

        public static string GeneratePasswordResetToken() {

            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder stringBuilder = new StringBuilder();

            using(RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {
                byte[] uintBuffer = new byte[sizeof(uint)];
                int length = GlobalConfig.PasswordResetTokenLength;

                while(length-- > 0) {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    stringBuilder.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return stringBuilder.ToString();
        }

        public static string FormatRating(float rating) {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            nfi.NumberDecimalDigits = 1;

            return rating.ToString(nfi);
        }

        public static string FormatReleseDate(DateTime? date) {
            return DateTime.SpecifyKind((DateTime)date, DateTimeKind.Local).ToString("dd.MM.yyyy");
        }
    }
}