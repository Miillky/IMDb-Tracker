using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTrackerLibrary.Exceptions {
    class UserNameExistsException : Exception {
        public UserNameExistsException() { }

        public UserNameExistsException(string message) : base(message) { }

        public UserNameExistsException(string message, Exception inner) : base(message, inner) { }
    }
}
