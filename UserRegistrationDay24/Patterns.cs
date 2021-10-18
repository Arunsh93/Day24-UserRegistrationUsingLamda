using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationDay24
{
    public class Patterns
    {
        public static string RegexPassword = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@!#$&])[A-Za-z0-9.@!#$&]{8,}$";
        public static string RegexName = "^[A-Z]{1}[a-z]{2,}$";
        public static string RegexEmailId = "^[A-Za-z0-9]+([-.+][0-9]+)?[0-9]*[@][A-Za-z0-9]+[.][a-zA-Z]{2,}([.][a-z]{2,})?$";
        public static string RegexPhoneNumber = "^[0-9]{2}[ ][0-9]{10}$";

        public bool IsValidFirstName(string firstName)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(firstName, RegexName));
                if (flag == true)
                    return true;
                else
                    return false;
            }
            while (flag == false);
        }

        public bool IsValidLastName(string lastName)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(lastName, RegexName));
                if (flag == true)
                    return true;
                else
                    return false;
            }
            while (flag == false);
        }

        public bool IsValidEmailId(string emailId)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(emailId, RegexEmailId));
                if (flag == true)
                    return true;
                else
                    return false;
            }
            while (flag == false);
        }

        public bool IsValidPassword(string password)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(password, RegexPassword));
                if (flag == true)
                    return true;
                else
                    return false;
            }
            while (flag == false);
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(phoneNumber, RegexPhoneNumber));
                if (flag == true)
                    return true;
                else
                    return false;
            }
            while (flag == false);
        }

        public bool IsValidSampleEmiailId(string sampleEmailId)
        {
            bool flag;
            do
            {
                flag = (Regex.IsMatch(sampleEmailId, RegexEmailId));
                if (flag == true)
                    return true;
                else
                    return false;
            }
            while (flag == false);
        }
    }
}
