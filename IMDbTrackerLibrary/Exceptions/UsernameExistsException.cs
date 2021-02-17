using System;

namespace IMDbTrackerLibrary.Exceptions {
    class UserNameExistsException : Exception {
        public UserNameExistsException() { }

        public UserNameExistsException(string message) : base(message) { }

        public UserNameExistsException(string message, Exception inner) : base(message, inner) { }
    }
}
