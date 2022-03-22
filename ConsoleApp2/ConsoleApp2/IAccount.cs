using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal interface IAccount
    {
        static bool PasswordChecker(string Password)
        {
            if (!string.IsNullOrEmpty(Password) && Password.Length > 7)
            {
                bool HasUpper = false;
                bool HasLower = false;
                bool HasDigit = false;
                for (int i = 0; i < Password.Length; i++)
                {
                    if (char.IsUpper(Password[i]))
                        HasUpper = true;
                    else if (char.IsLower(Password[i]))
                        HasLower = true;
                    else if (char.IsDigit(Password[i]))
                        HasDigit = true;
                }
                if (HasUpper && HasLower && HasDigit)
                    return true;
            }
            return false;
        }
        public string ShowInfo();
    }
}
