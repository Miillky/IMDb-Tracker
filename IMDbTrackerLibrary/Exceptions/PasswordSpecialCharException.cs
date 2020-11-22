using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTrackerLibrary.Exceptions {
    class PasswordSpecialCharException : Exception {

        public PasswordSpecialCharException() { }

        public PasswordSpecialCharException(string message) : base(message) { }

        public PasswordSpecialCharException(string message, Exception inner) : base(message, inner) { }
    }
}
