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
        public Regex ValidateName = new Regex(@"^[A-Z][a-z]{2,}$");
        public Regex ValidateEmail = new Regex("^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$");
        public Regex ValidateMobile = new Regex("^[0-9]{2}[ ][6-9][0-9]{9}$");
        public Regex Validatepassword = new Regex ("^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^!@#$%_]*[!@#$%_][^!@#$%_]*$)[A-Za-z0-9!@#$%_]{8,}$");
        public string CheckName(string name)
        {
            bool NamePattern(string FirstNamePattern) => ValidateName.IsMatch(name);
            bool result = NamePattern(name);
            

            //string validateName = "^[A-Z][a-z]{2,}$";
            try
            {
                if (name.Equals(string.Empty))
                {
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.EMPTY_INPUT, "Input Should Not Be Empty");
                }
                if (result)
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
            bool EmailPattern(string FirstNamePattern) => ValidateEmail.IsMatch(email);
            bool result = EmailPattern(email);
            //string validateEmail = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$";
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.EMPTY_INPUT, "Input Should Not Be Empty");
                }
                if (result)
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
            bool MobileNoPattern(string MobileNotNamePattern) => ValidateMobile.IsMatch(mobile);
            bool result = MobileNoPattern(mobile);
            //string validateMobile = "^[0-9]{2}[ ][6-9][0-9]{9}$";
            try
            {
                if (mobile.Equals(string.Empty))
                {
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.EMPTY_INPUT, "Input Should Not Be Empty");
                }
                if (result)
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
            //string validatepassword = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^!@#$%_]*[!@#$%_][^!@#$%_]*$)[A-Za-z0-9!@#$%_]{8,}$";
            try
            {
                bool PasswordNPattern(string PasswordPattern) => Validatepassword.IsMatch(password);
                bool result = PasswordNPattern(password);
                if (password.Equals(string.Empty))
                {
                    throw new UserValidationExceptions(UserValidationExceptions.ExceptionType.EMPTY_INPUT, "Input Should Not Be Empty");
                }
                if (result)
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
