using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration
{
    internal class RegexValidation
    {
        public void CheckFirstName(string firstname)
        {
            string validateFirstName = "^[A-Z][a-z]{3,20}$";
            try
            {
                if (Regex.IsMatch(firstname, validateFirstName))
                    Console.WriteLine("First Name Valid");
                else
                    Console.WriteLine("Invalid name!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
