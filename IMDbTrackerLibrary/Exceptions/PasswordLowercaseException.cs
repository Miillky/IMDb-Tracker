using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTrackerLibrary.Exceptions {
    class PasswordLowercaseException : Exception {

        public PasswordLowercaseException() { }

        public PasswordLowercaseException(string message) : base(message) { }

        public PasswordLowercaseException(string message, Exception inner) : base(message, inner) { }
    }
}
