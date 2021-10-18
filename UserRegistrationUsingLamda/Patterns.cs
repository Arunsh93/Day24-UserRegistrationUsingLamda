using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLamda
{
    public class Patterns
    {
        public Func<string, string, bool> ValidPasswordRule = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> ValidFirstName = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> ValidLastName = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> ValidEmailId = (x, y) => Regex.IsMatch(x, y);
        public Func<string, string, bool> ValidPhoneNumber = (x, y) => Regex.IsMatch(x, y);
    }
}
