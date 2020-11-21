using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTrackerLibrary.Exceptions {
    class NotMatchingPasswordsException : Exception {

        public NotMatchingPasswordsException() {}

        public NotMatchingPasswordsException(string message) : base(message) {}

        public NotMatchingPasswordsException(string message, Exception inner) : base(message, inner) {}

    }
}
