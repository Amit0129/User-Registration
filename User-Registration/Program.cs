namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexValidation regex = new RegexValidation();
            Console.WriteLine("User registration Problem statement");
            Console.WriteLine("*First letter should be capital.");
            Console.WriteLine("*length should be Minimum three characters.");
            Console.WriteLine("Enter First name :");
            string fname = Console.ReadLine();
            regex.CheckName(fname);
            Console.WriteLine("Enter Last name :");
            string lname = Console.ReadLine();
            regex.CheckName(lname);
            Console.WriteLine("Enter Email id :");
            string email = Console.ReadLine();
            regex.CheckEmail(email);
        }
    }
}