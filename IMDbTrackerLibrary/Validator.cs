using System;
using System.Net.Mail;
using System.Reflection;

namespace IMDbTrackerLibrary {
    public static class Validator {

        public static bool Required(string fieldValue, string fieldName) {
            if(string.IsNullOrWhiteSpace(fieldValue)) {
                throw new ArgumentException($"{fieldName} is required");
            }
            return true;
        }

        public static bool Email(string fieldValue, string fieldName) {
            MailAddress address = new MailAddress(fieldValue);
            if(address.Address != fieldValue) {
                throw new FormatException($"{fieldName} is not a valid email addres");
            }
            return true;
        }
    }
}
