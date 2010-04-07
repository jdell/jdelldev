using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ambis1.model.bl._common.custom
{
    public class Alert
    {
        String _message = string.Empty;

        public String Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public override string ToString()
        {
            return this.Message;
        }
    }
}
