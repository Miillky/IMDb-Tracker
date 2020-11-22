using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTrackerLibrary.Exceptions {
    class PasswordDigitsException : Exception {
        public PasswordDigitsException() { }

        public PasswordDigitsException(string message) : base(message) { }

        public PasswordDigitsException(string message, Exception inner) : base(message, inner) { }
    }
}
