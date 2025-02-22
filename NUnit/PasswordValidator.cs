using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nunit_Assignment
{
    public class PasswordValidator
    {
        public bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;
            if (!Regex.IsMatch(password, @"[A-Z]")) // At least one uppercase letter
                return false;
            if (!Regex.IsMatch(password, @"\d")) // At least one digit
                return false;

            return true;
        }
    }
}
