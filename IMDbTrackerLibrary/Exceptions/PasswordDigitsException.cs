using System;

namespace IMDbTrackerLibrary.Exceptions {
    class PasswordDigitsException : Exception {
        public PasswordDigitsException() { }

        public PasswordDigitsException(string message) : base(message) { }

        public PasswordDigitsException(string message, Exception inner) : base(message, inner) { }
    }
}
