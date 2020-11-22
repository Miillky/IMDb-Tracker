using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTrackerLibrary.Exceptions {
    class PasswordUppercaseException : Exception {
        public PasswordUppercaseException() { }

        public PasswordUppercaseException(string message) : base(message) { }

        public PasswordUppercaseException(string message, Exception inner) : base(message, inner) { }
    }
}
