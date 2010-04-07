using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolToSendEmails.smallmvc
{
    internal class customerVO
    {
        private string _name = string.Empty;

        public string Name
        {
            get { return _name; }
            set { _name = value.Trim(); }
        }
        private string _email = string.Empty;

        public string Email
        {
            get { return _email; }
            set { _email = value.Trim(); }
        }
    }
}
