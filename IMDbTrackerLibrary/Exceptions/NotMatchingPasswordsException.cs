using System;

namespace IMDbTrackerLibrary.Exceptions {
    class NotMatchingPasswordsException : Exception {

        public NotMatchingPasswordsException() {}

        public NotMatchingPasswordsException(string message) : base(message) {}

        public NotMatchingPasswordsException(string message, Exception inner) : base(message, inner) {}

    }
}
