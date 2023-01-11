using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    public class RegexValidation
    {
        public bool CheckName(string name)
        {
            string validateName = "^[A-Z][a-z]{2,}$";
            try
            {
                if (Regex.IsMatch(name, validateName))
                    //Console.WriteLine("validate succesfull");
                    return true;

                else
                    //Console.WriteLine("Invalid name!!");
                    return false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public bool CheckEmail(string email)
        {
            string validateEmail = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$";
            try
            {
                if (Regex.IsMatch(email, validateEmail))
                    //Console.WriteLine(" email validate succesfull");
                    return true;
                else
                    //Console.WriteLine("Invalid email!!");
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public bool CheckMobileNo(string mobile)
        {
            string validateMobile = "^[0-9]{2}[ ][6-9][0-9]{9}$";
            try
            {
                if (Regex.IsMatch(mobile, validateMobile))
                    //Console.WriteLine(" mobile no validate succesfull");
                    return true;
                else
                    //Console.WriteLine("Invalid mobile no.!!");
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public bool CheckPassword(string password)
        {
            string validatepassword = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^!@#$%_]*[!@#$%_][^!@#$%_]*$)[A-Za-z0-9!@#$%_]{8,}$";
            try
            {
                if (Regex.IsMatch(password, validatepassword))
                    //Console.WriteLine("password validate succesfull");
                    return true;
                else
                    //Console.WriteLine("Invalid password!!");
                    return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
    }
}
