using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace User_Registration
{
    public class RegexValidation
    {
        public string CheckName(string name)
        {
            string validateName = "^[A-Z][a-z]{2,}$";
            try
            {
                if (name.Equals(string.Empty))
                {
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.EMPTY_INPUT, "Input Should Not Be Empty");
                }
                if (Regex.IsMatch(name, validateName))
                    return "Input Valid";

                else
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.INVALID_INPUT, "Input Is Not Valid");

            }
            catch (NullReferenceException)
            {
                throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.NULL_INPUT, "Input Should Not Be Null");
            }
        }
        public string CheckEmail(string email)
        {
            string validateEmail = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$";
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.EMPTY_INPUT, "Input Should Not Be Empty");
                }
                if (Regex.IsMatch(email, validateEmail))
                    return "Input Valid";
                else
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.INVALID_INPUT, "Input Is Not Valid");

            }
            catch (NullReferenceException)
            {
                throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.NULL_INPUT, "Input Should Not Be Null");
            }
        }
        public string CheckMobileNo(string mobile)
        {
            string validateMobile = "^[0-9]{2}[ ][6-9][0-9]{9}$";
            try
            {
                if (mobile.Equals(string.Empty))
                {
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.EMPTY_INPUT, "Input Should Not Be Empty");
                }
                if (Regex.IsMatch(mobile, validateMobile))
                    return "Input Valid";
                else
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.INVALID_INPUT, "Input Is Not Valid");
            }
            catch (NullReferenceException)
            {
                throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.NULL_INPUT, "Input Should Not Be Null");
            }
        }

        public string CheckPassword(string password)
        {
            string validatepassword = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^!@#$%_]*[!@#$%_][^!@#$%_]*$)[A-Za-z0-9!@#$%_]{8,}$";
            try
            {
                if (password.Equals(string.Empty))
                {
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.EMPTY_INPUT, "Input Should Not Be Empty");
                }
                if (Regex.IsMatch(password, validatepassword))
                    return "Input Valid";
                else
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.INVALID_INPUT, "Input Is Not Valid");
            }
            catch (NullReferenceException)
            {
                throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.NULL_INPUT, "Input Should Not Be Null");
            }
        }
    }
}
