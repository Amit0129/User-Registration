using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration
{
    public class UserValidationExceptions : Exception
    {
        public enum ExceptionType
        {
            NULL_INPUT,
            EMPTY_INPUT,
            INVALID_INPUT
        }
        private readonly ExceptionType type;
        public UserValidationExceptions(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }

}
