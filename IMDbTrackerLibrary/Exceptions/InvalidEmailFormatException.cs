using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTrackerLibrary.Exceptions {
    class InvalidEmailFormatException : Exception {

        public InvalidEmailFormatException() { }

        public InvalidEmailFormatException(string message) : base(message) { }

        public InvalidEmailFormatException(string message, Exception inner) : base(message, inner) { }
    }
}
