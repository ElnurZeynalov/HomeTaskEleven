using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class User : IAccount
    {
        private string _password;
        public string _fulName;
        public string _email;
        public string FulName
        {
            get
            {
                return _fulName;
            }
            set
            {
                if (value.Length > 8)
                _fulName = value;
            }
        }
        public string Email
        {
            get
            {
                
                return _email;
            }
            set
            {
                if (value.Length > 10)
                _email = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (IAccount.PasswordChecker(value))
                    _password = value;
            }
        }
        public User (string Fulname,string Email)
        {
            Fulname = Fulname;
            Email = Email;
        }
        public string ShowInfo()
        {
            return $"FulName: {_fulName} Email: {_email}";
        }
    }
}