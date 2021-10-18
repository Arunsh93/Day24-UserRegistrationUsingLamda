using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationDay24
{
    class UserRegisrationCustomException : Exception
    {
        public enum ExceptionType
        {
            Invalid_FirstName,
            Invalid_LastName,
            Invalid_EmailId,
            Invalid_Password,
            Invalid_PhoneNumber,
        }
        private ExceptionType type;
        public UserRegisrationCustomException(ExceptionType type,string message):base(message)
        {
            this.type = type;
        }
    }
}
