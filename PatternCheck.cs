using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
   public class PatternCheck
    {
        public const string patternForFName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string patternForLName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string patternForEmail = "^[a-z]{3,}([.$#%]?[a-z]+)?[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}([.]?[a-z]+)?$";
        public const string patternForPhoneNo = "^[1-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public const string Regex_Password = "[A-Za-z0-9!@#$%^&*_-]{8,}$";
        public const string Regex_Password6 = "[A-Z]{1,}[A-Za-z0-9!@#$%^&*_-]{7,}$";
        public const string REGEX_PASSWORD7 = "[A-Z]{1,}[0-9]{1,}[A-Za-z0-9!@#$%^&*_-]{6,}$";
        public const string REGEX_PASSWORD8 = "[A-Z]{1,}[0-9]{1,}[!@#$%^&_-]{1,}[A-Za-z0-9!@#$%^&_-]{5,}$";
        public bool FirstNameValidation(string FirstName)
        {
            return Regex.IsMatch(FirstName, patternForFName);
        }
        public bool LastNameValidation(string LastName)
        {
            return Regex.IsMatch(LastName, patternForLName);
        }
        public bool EmailValidation(string Email)
        {
            return Regex.IsMatch(Email, patternForEmail);
        }
        public bool PhoneNoValidation(string PhoneNo)
        {
            return Regex.IsMatch(PhoneNo, patternForPhoneNo);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, Regex_Password);
        }
        public bool ValidatePassword6(string password6)
        {
            return Regex.IsMatch(password6, Regex_Password6);
        }
        public bool ValidatePassword7(string password7)
        {
            return Regex.IsMatch(password7, REGEX_PASSWORD7);
        }
        public bool ValidatePassword8(string password8)
        {
            return Regex.IsMatch(password8, REGEX_PASSWORD8);
        }
        public bool UC9(string UC9)
        {
            return Regex.IsMatch(UC9, patternForEmail);
        }

    }
}
    
