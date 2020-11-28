using System;

namespace IMDbTrackerLibrary.Exceptions {
    class InvalidEmailFormatException : Exception {

        public InvalidEmailFormatException() { }

        public InvalidEmailFormatException(string message) : base(message) { }

        public InvalidEmailFormatException(string message, Exception inner) : base(message, inner) { }
    }
}
