using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTrackerLibrary.Exceptions {
    class APIKeyExistsException : Exception {
        public APIKeyExistsException() { }

        public APIKeyExistsException(string message) : base(message) { }

        public APIKeyExistsException(string message, Exception inner) : base(message, inner) { }
    }
}
