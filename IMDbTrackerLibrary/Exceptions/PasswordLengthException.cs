using System;

namespace IMDbTrackerLibrary.Exceptions {
    class PasswordLengthException : Exception {
        public PasswordLengthException() { }

        public PasswordLengthException(string message) : base(message) { }

        public PasswordLengthException(string message, Exception inner) : base(message, inner) { }
    }
}
