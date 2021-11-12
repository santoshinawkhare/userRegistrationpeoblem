using System;
using System.Collections.Generic;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 19 Problem!");

            PatternCheck regexValidation = new PatternCheck();
            Console.WriteLine("Enter Your First Name - UC1");
            string firstName = Console.ReadLine();
            Console.WriteLine(regexValidation.FirstNameValidation(firstName));
            Console.WriteLine("Enter Your Last Name - UC2");
            string lastName = Console.ReadLine();
            Console.WriteLine(regexValidation.LastNameValidation(lastName));
            Console.WriteLine("Enter Your Email Address - UC3");
            string email = Console.ReadLine();
            Console.WriteLine(regexValidation.EmailValidation(email));
            Console.WriteLine("Enter Your Mobile Number - UC4");
            string mobileNum = Console.ReadLine();
            Console.WriteLine(regexValidation.PhoneNoValidation(mobileNum));
            Console.WriteLine("Enter Your Password(Minimum 8 Char) - UC5");
            string password = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidatePassword7(password));
            Console.WriteLine("Enter Your Password(At Least One Upper Case - UC6");
            string password6 = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidatePassword7(password));
            Console.WriteLine("Enter Your Password(At Least One Numeric Number) - UC7");
            string password7 = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidatePassword8(password7));
            Console.WriteLine("Enter Your Password(At Least One Special Char) - UC8");
            string password8 = Console.ReadLine();
            Console.WriteLine(regexValidation.ValidatePassword(password8));
            Console.WriteLine("Enter Your Password(Clear All Email Sample) - UC9");
            string UC9 = Console.ReadLine();
            Console.WriteLine(regexValidation.UC9(UC9));

            //Validating Sample Emails

            List<string> sampleEmailList = new List<string>()
            {
                "abc@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc111@abc.com",
                "abc-100@abc.net",
                "abc.100@abc.com.au",
                "abc@1.com",
                "abc@gmail.com.com",
                "abc+100@gmail.com"
            };
            foreach (string item in sampleEmailList)
            {
                if (regexValidation.EmailValidation(item))
                {
                    Console.WriteLine("Valid Email");
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }
        }
    }
}
