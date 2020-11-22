using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTrackerLibrary.Exceptions {
    class PasswordLengthException : Exception {
        public PasswordLengthException() { }

        public PasswordLengthException(string message) : base(message) { }

        public PasswordLengthException(string message, Exception inner) : base(message, inner) { }
    }
}
