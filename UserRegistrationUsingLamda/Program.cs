using System;

namespace UserRegistrationUsingLamda
{
    class Program
    {
        public static string RegexPassword = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@!#$&])[A-Za-z0-9.@!#$&]{8,}$";
        public static string RegexName = "^[A-Z]{1}[a-z]{2,}$";
        public static string RegexEmailId = "^[A-Za-z0-9]+([-.+][0-9]+)?[0-9]*[@][A-Za-z0-9]+[.][a-zA-Z]{2,}([.][a-z]{2,})?$";
        public static string RegexPhoneNumber = "^[0-9]{2}[ ][0-9]{10}$";
        static Patterns pattern = new Patterns();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            if(pattern.ValidFirstName(firstName, RegexName) == true)
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
            Console.ReadKey();

            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            if (pattern.ValidLastName(lastName, RegexName) == true)
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
            Console.ReadKey();

            Console.WriteLine("Enter EmailId: ");
            string emailId = Console.ReadLine();
            if (pattern.ValidEmailId(emailId, RegexEmailId) == true)
            {
                Console.WriteLine("Valid EmailId");
            }
            else
            {
                Console.WriteLine("Invalid EmailId");
            }
            Console.ReadKey();

            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            if (pattern.ValidPasswordRule(password, RegexPassword) == true)
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
            Console.ReadKey();

            Console.WriteLine("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();
            if (pattern.ValidPhoneNumber(phoneNumber, RegexPhoneNumber) == true)
            {
                Console.WriteLine("Valid Phone Number");
            }
            else
            {
                Console.WriteLine("Invalid Phone Number");
            }
            Console.ReadKey();
        }
    }
}
