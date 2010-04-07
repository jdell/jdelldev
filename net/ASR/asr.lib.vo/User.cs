using System;
using System.Collections.Generic;
using System.Text;

namespace asr.lib.vo
{
    public class User
    {
        public User(string login)
        {
            this._login = login;
        }
        private string _login;
        public string Login
        {
            get { return _login.ToUpper(); }
            set { _login = value; }
        }


        private string _firstName = string.Empty;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _middleName = string.Empty;

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }
        private string _lastName = string.Empty;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}
