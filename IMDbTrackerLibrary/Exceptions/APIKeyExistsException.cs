using System;

namespace IMDbTrackerLibrary.Exceptions {
    class APIKeyExistsException : Exception {
        public APIKeyExistsException() { }

        public APIKeyExistsException(string message) : base(message) { }

        public APIKeyExistsException(string message, Exception inner) : base(message, inner) { }
    }
}
