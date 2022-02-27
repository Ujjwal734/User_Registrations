using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registrations
{
    public class UserRegistrationException:Exception
    {
        public ExceptionType type;
            //Enumeration
        public enum ExceptionType
        {
             EXCEPTION
        }
            //Exception class Constructor.
        public UserRegistrationException(ExceptionType type, string message) : base(message)
        {
             this.type = type;
        }
    }
}
